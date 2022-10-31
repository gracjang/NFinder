namespace NFinder.Application.Handlers;

using MediatR;
using NFinder.Application.DTOs.Requests;
using NFinder.Application.DTOs.Responses;

public class GetProcessingJobsHandler : IRequestHandler<GetProcessingJobsRequest, GetProcessingJobsResponse>
{
    public Task<GetProcessingJobsResponse> Handle(GetProcessingJobsRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}