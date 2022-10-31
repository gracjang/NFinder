namespace NFinder.Domain.ValueObjects;

using NFinder.Domain.Exceptions;

public sealed record JobStatus
{
    private const string ProcessedStatus = "processed";
    private const string PendingStatus = "pending";
    private const string FailedStatus = "failed";
    
    public static IEnumerable<string> AvailableStatuses { get; } = new[] {ProcessedStatus, PendingStatus, FailedStatus};
    public string Value { get; }
    
    public JobStatus(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new InvalidJobStatusException(value);
        }

        if (!AvailableStatuses.Contains(value))
        {
            throw new InvalidJobStatusException(value);
        }

        Value = value;
    }

    public static JobStatus Pending() => new(PendingStatus);
    public static JobStatus Processed() => new(ProcessedStatus);
    public static JobStatus Failed() => new(FailedStatus);
    
    public static implicit operator string(JobStatus combination) => combination.Value;

    public static implicit operator JobStatus(string jobStatus) => new(jobStatus);
    
    public override string ToString() => Value;
}