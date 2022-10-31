namespace NFinder.Application.Handlers;

using MediatR;
using NFinder.Application.DTOs.Requests;
using NFinder.Application.DTOs.Responses;

public class StartJobHandler : IRequestHandler<StartJobRequest, StartJobResponse>
{

    public Task<StartJobResponse> Handle(StartJobRequest request, CancellationToken cancellationToken)
    {
        
        throw new NotImplementedException();
    }
}