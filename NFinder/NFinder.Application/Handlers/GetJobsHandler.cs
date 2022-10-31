namespace NFinder.Application.Handlers;

using MediatR;
using NFinder.Application.DTOs.Models;
using NFinder.Application.DTOs.Requests;
using NFinder.Application.DTOs.Responses;
using NFinder.Domain.Repositories;

public class GetJobsHandler : IRequestHandler<GetJobsRequest, GetJobsResponse>
{
    private readonly IJobsRepository _jobsRepository;

    public GetJobsHandler(IJobsRepository jobsRepository)
    {
        _jobsRepository = jobsRepository;
    }

    public async Task<GetJobsResponse> Handle(GetJobsRequest request, CancellationToken cancellationToken)
    {
        _ = request ?? throw new ArgumentNullException(nameof(request));
        
        var jobs = await _jobsRepository.GetAll();
        return new GetJobsResponse(jobs.Select(x => new JobDto(x.Id, x.Status)));
    }
}