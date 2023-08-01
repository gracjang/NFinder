namespace NFinder.Application.DTOs.Requests;

using NFinder.Application.DTOs.Responses;
using NFinder.Infrastructure.Models;

public sealed record GetJobRequest(Guid JobId) : IFinderRequest<GetJobResponse>;