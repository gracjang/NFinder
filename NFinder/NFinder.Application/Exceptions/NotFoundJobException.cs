namespace NFinder.Application.Exceptions;

using NFinder.Domain.Exceptions;

public class NotFoundJobException : FinderException
{
    public Guid JobId { get; }

    public NotFoundJobException(Guid jobId) : base($"Job with Id: [{jobId.ToString()}] was not found.")
    {
        JobId = jobId;
    }
}