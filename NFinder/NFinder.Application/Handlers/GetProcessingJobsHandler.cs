namespace NFinder.Application.Handlers;

using MediatR;
using NFinder.Application.DTOs.Requests;
using NFinder.Application.DTOs.Responses;
using NFinder.Application.Exceptions;
using NFinder.Domain.Repositories;
using NFinder.Domain.ValueObjects;

public class GetProcessingJobsHandler : IRequestHandler<GetProcessingJobsRequest, GetProcessingJobsResponse>
{
    private readonly IJobsRepository _jobsRepository;

    public GetProcessingJobsHandler(IJobsRepository jobsRepository)
    {
        _jobsRepository = jobsRepository;
    }

    public async Task<GetProcessingJobsResponse> Handle(GetProcessingJobsRequest request, CancellationToken cancellationToken)
    {
        _ = request ?? throw new ArgumentNullException(nameof(request));

        var jobs = await _jobsRepository.GetAll();
        
        var processingJobsCount = jobs.Count(x => x.Status == JobStatus.Failed());
        return processingJobsCount != 0 
            ? new GetProcessingJobsResponse(processingJobsCount) 
            : throw new NotFoundProcessingJobException() ;
    }
}