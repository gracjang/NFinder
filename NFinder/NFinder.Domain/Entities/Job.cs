namespace NFinder.Domain.Entities;

using NFinder.Domain.Exceptions;
using NFinder.Domain.ValueObjects;

public sealed class Job
{
    public JobId Id { get; }

    public JobStatus Status { get; }

    public IEnumerable<Combination> Combinations => _combinations;

    private readonly HashSet<Combination> _combinations = new();

    internal Job(JobId id, JobStatus status)
    {
        Id = id;
        Status = status;
    }

    internal void AddCombination(Combination combination)
    {
        if (_combinations.Any(x => x.Value == combination.Value))
        {
            throw new CombinationExistException(combination.Value);
        }

        _combinations.Add(combination);
    }
    
}