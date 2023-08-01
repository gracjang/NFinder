namespace NFinder.Application.Services;

using Microsoft.Extensions.Hosting;
using NFinder.Application.Channels;
using NFinder.Domain.Entities;
using NFinder.Domain.Repositories;
using NFinder.Domain.ValueObjects;

public class BackgroundJobService : BackgroundService
{
    private readonly JobChannel _channel;
    private readonly IJobsRepository _jobsRepository;

    public BackgroundJobService(JobChannel channel, IJobsRepository jobsRepository)
    {
        _channel = channel;
        _jobsRepository = jobsRepository;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        await foreach (var processJob in _channel.Subscribe(stoppingToken))
        {
            try
            {
                var job = new Job(processJob.JobId, JobStatus.Pending());
                await _jobsRepository.Add(job);

                var combinations = processJob.Combinations;
                var resultStrings = combinations.Where(x => x.Length <= processJob.Max || x.Length >= processJob.Min);

                foreach (var result in resultStrings)
                {
                    job.AddCombination(result);
                }

                job.ChangeStatus(JobStatus.Processed());
                await _jobsRepository.Update(job);
            }
            catch (Exception ex)
            {
                await _jobsRepository.UpdateStatus(new JobId(processJob.JobId), JobStatus.Failed());
                // message to Db & process exception
            }
        }
    }
}