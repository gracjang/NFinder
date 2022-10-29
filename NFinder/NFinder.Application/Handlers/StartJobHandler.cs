namespace NFinder.Application.Handlers;

using MediatR;
using NFinder.Application.Requests;
using NFinder.Application.Responses;

public class StartJobHandler : IRequestHandler<StartJobRequest, StartJobResponse>
{

    public Task<StartJobResponse> Handle(StartJobRequest request, CancellationToken cancellationToken)
    {
        
        throw new NotImplementedException();
    }
}