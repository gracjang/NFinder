namespace NFinder.Application.Services;

using Microsoft.Extensions.Hosting;
using NFinder.Application.Channels;

public class BackgroundJobService : BackgroundService
{
    private readonly JobChannel _channel;
    private readonly IJobProcessor _jobProcessor;

    public BackgroundJobService(JobChannel channel, IJobProcessor jobProcessor)
    {
        _channel = channel;
        _jobProcessor = jobProcessor;
    }

    protected override async  Task ExecuteAsync(CancellationToken stoppingToken)
    {
        await foreach (var request in _channel.Subscribe(stoppingToken))
        {
            await _jobProcessor.Process(request);
        }
    }
}