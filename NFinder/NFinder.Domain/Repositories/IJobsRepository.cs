namespace NFinder.Domain.Repositories;

using NFinder.Domain.Entities;
using NFinder.Domain.ValueObjects;

public interface IJobsRepository
{
    Task<Job> GetById(JobId jobId);
    Task<IEnumerable<Job>> GetAll();
    Task Add(Job job);
}