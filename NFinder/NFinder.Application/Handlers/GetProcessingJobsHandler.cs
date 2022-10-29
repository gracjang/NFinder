namespace NFinder.Application.Handlers;

using MediatR;
using NFinder.Application.Requests;
using NFinder.Application.Responses;

public class GetProcessingJobsHandler : IRequestHandler<GetProcessingJobsRequest, GetProcessingJobsResponse>
{
    public Task<GetProcessingJobsResponse> Handle(GetProcessingJobsRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}