namespace NFinder.Application.DTOs.Requests;

using NFinder.Application.DTOs.Responses;
using NFinder.Infrastructure.Models;

public sealed record StartJobRequest(IEnumerable<char> Characters, int Count, int max, int min) : IFinderRequest<StartJobResponse>;