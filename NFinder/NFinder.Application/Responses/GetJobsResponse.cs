namespace NFinder.Application.Responses;

using NFinder.Infrastructure.Models;

public sealed class GetJobsResponse : ResponseBase
{
    public Guid JobId { get; set; }

    public string JobStatus { get; set; }
}