namespace NFinder.Application.Requests;

using NFinder.Application.Responses;
using NFinder.Infrastructure.Models;

public sealed record StartJobRequest(IEnumerable<char> Characters, int Count) : IFinderRequest<StartJobResponse>;