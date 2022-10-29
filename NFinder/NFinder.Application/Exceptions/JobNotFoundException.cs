namespace NFinder.Application.Exceptions;

using NFinder.Domain.Exceptions;

public class JobNotFoundException : FinderException
{
    public Guid JobId { get; }

    public JobNotFoundException(Guid jobId) : base($"Job with Id: [{jobId.ToString()}] was not found.")
    {
        JobId = jobId;
    }
}