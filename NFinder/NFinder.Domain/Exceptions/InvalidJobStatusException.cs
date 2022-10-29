namespace NFinder.Domain.Exceptions;

public class InvalidJobStatusException : DomainException
{
    public object JobStatus { get; }

    public InvalidJobStatusException(object jobStatus) : base($"Cannot set status: {jobStatus} as a JobStatus.") => JobStatus = jobStatus;
}