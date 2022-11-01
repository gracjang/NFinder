namespace NFinder.Application.Channels.Models;

public sealed class ProcessJob
{
    public ProcessJob(Guid jobId, int max, int min, List<string> combinations)
    {
        Max = max;
        Min = min;
        Combinations = combinations;
    }

    public Guid JobId { get; }
    
    public int Max { get; }

    public int Min { get; }

    public List<string> Combinations { get; }
}