namespace NFinder.Application.Responses;

using NFinder.Infrastructure.Models;

public sealed class GetProcessingJobsResponse : ResponseBase
{
    public int ProcessingJobs { get; set; }
}