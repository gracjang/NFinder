namespace NFinder.Application.DTOs.Responses;

using NFinder.Infrastructure.Models;

public sealed class GetProcessingJobsResponse : ResponseBase
{
    public GetProcessingJobsResponse(int processingJobsCount)
    {
        ProcessingJobsCount = processingJobsCount;
    }
    public int ProcessingJobsCount { get; }
}