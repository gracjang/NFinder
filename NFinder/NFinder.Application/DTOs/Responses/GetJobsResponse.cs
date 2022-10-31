namespace NFinder.Application.DTOs.Responses;

using NFinder.Application.DTOs.Models;
using NFinder.Infrastructure.Models;

public sealed class GetJobsResponse : ResponseBase
{
    public GetJobsResponse(IEnumerable<JobDto> jobs)
    {
        Jobs = jobs;
    }
    
    public IEnumerable<JobDto> Jobs { get; }
}