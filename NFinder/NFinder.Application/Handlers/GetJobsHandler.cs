namespace NFinder.Application.Handlers;

using MediatR;
using MediatR.Pipeline;
using NFinder.Application.Requests;
using NFinder.Application.Responses;

public class GetJobsHandler : IRequestHandler<GetJobsRequest, GetJobsResponse>
{

    public Task<GetJobsResponse> Handle(GetJobsRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}