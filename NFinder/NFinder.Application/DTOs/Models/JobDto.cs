namespace NFinder.Application.DTOs.Models;

public sealed class JobDto
{
    public JobDto(Guid jobId, string status)
    {
        JobId = jobId;
        Status = status;
    }
    
    public Guid JobId { get; }

    public string Status { get; }
}