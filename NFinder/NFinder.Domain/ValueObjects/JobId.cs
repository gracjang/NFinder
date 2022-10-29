namespace NFinder.Domain.ValueObjects;

using NFinder.Domain.Exceptions;

public sealed record JobId
{
    public Guid Value { get; }

    public JobId(Guid value)
    {
        if (value == Guid.Empty)
        {
            throw new InvalidObjectIdException(value);
        }

        Value = value;
    }
    
    public static implicit operator Guid(JobId jobId) => jobId.Value;
    public static implicit operator JobId(Guid value) => new(value);
}