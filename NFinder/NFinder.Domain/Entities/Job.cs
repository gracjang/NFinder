namespace NFinder.Domain.Entities;

using NFinder.Domain.Exceptions;
using NFinder.Domain.ValueObjects;

public sealed class Job
{
    public JobId Id { get; }

    public JobStatus Status { get; private set; }

    public IEnumerable<Combination> Combinations => _combinations;

    private readonly HashSet<Combination> _combinations = new();

    public Job(JobId id, JobStatus status)
    {
        Id = id;
        Status = status;
    }

    public void AddCombination(Combination combination)
    {
        if (_combinations.Any(x => x.Value == combination.Value))
        {
            throw new CombinationExistException(combination.Value);
        }

        _combinations.Add(combination);
    }
    
    public void ChangeStatus(JobStatus status)
    {
        Status = new JobStatus(status);
    }
}