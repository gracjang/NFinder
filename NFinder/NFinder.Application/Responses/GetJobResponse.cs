namespace NFinder.Application.Responses;

using NFinder.Infrastructure.Models;

public sealed class GetJobResponse : ResponseBase
{
    public Guid JobId { get; set; }

    public string Status { get; set; }

    public IEnumerable<string> Combination { get; set; }
}