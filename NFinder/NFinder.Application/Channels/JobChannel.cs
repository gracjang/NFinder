namespace NFinder.Application.Channels;

using System.Threading.Channels;
using NFinder.Application.DTOs.Requests;

public class JobChannel
{
    private readonly Channel<StartJobRequest> _channel = Channel.CreateUnbounded<StartJobRequest>();

    public ValueTask Publish(StartJobRequest jobRequest) => _channel.Writer.WriteAsync(jobRequest);

    public IAsyncEnumerable<StartJobRequest> Subscribe(CancellationToken cancellationToken) => _channel.Reader.ReadAllAsync(cancellationToken);
}