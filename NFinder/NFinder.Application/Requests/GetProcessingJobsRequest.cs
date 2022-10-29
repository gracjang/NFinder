namespace NFinder.Application.Requests;

using NFinder.Application.Responses;
using NFinder.Infrastructure.Models;

public sealed record GetProcessingJobsRequest : IFinderRequest<GetProcessingJobsResponse>;