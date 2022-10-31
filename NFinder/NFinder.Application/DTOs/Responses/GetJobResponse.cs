namespace NFinder.Application.DTOs.Responses;

using NFinder.Infrastructure.Models;

public sealed class GetJobResponse : ResponseBase
{
    public GetJobResponse(Guid jobId, string status, IEnumerable<string> combination)
    {
        JobId = jobId;
        Status = status;
        Combination = combination;
    }
    public Guid JobId { get; }

    public string Status { get; }

    public IEnumerable<string> Combination { get; }
}