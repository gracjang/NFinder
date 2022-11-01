namespace NFinder.Application.Services;

using NFinder.Application.DTOs.Requests;

public interface IJobProcessor
{
    Task Process(StartJobRequest request);
}