namespace NFinder.Application.Handlers;

using MediatR;
using NFinder.Application.Exceptions;
using NFinder.Application.Requests;
using NFinder.Application.Responses;
using NFinder.Domain.Entities;
using NFinder.Domain.Repositories;
using NFinder.Domain.ValueObjects;

public class GetJobHandler : IRequestHandler<GetJobRequest, GetJobResponse>
{
    private readonly IJobsRepository _jobRepository;

    public GetJobHandler(IJobsRepository jobRepository)
    {
        _jobRepository = jobRepository;
    }

    public async Task<GetJobResponse> Handle(GetJobRequest request, CancellationToken cancellationToken)
    {
        _ = request ?? throw new ArgumentNullException(nameof(request));

        var jobId = new JobId(request.JobId);
        var job = await _jobRepository.GetById(jobId);
        if (job == null)
        {
            throw new JobNotFoundException(jobId.Value);
        }

        return new GetJobResponse()
        {
            Combination = job.Combinations.Select(x => x.Value),
            JobId = job.Id.Value,
            Status = job.Status.Value
        };
    }
}