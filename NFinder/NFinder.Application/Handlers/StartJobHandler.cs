namespace NFinder.Application.Handlers;

using MediatR;
using NFinder.Application.Channels;
using NFinder.Application.DTOs.Requests;
using NFinder.Application.DTOs.Responses;

public class StartJobHandler : IRequestHandler<StartJobRequest, StartJobResponse>
{
    private readonly JobChannel _jobChannel;

    public StartJobHandler(JobChannel jobChannel)
    {
        _jobChannel = jobChannel;
    }

    public async Task<StartJobResponse> Handle(StartJobRequest request, CancellationToken cancellationToken)
    {
        _ = request ?? throw new NullReferenceException(nameof(request));

        await _jobChannel.Publish(request);
        return new StartJobResponse();
    }
}