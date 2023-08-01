namespace NFinder.Application.Channels;

using System.Threading.Channels;
using NFinder.Application.Channels.Models;
using NFinder.Application.DTOs.Requests;

public class JobChannel
{
    private readonly Channel<ProcessJob> _channel = Channel.CreateUnbounded<ProcessJob>();

    public ValueTask Publish(ProcessJob processJob) => _channel.Writer.WriteAsync(processJob);

    public IAsyncEnumerable<ProcessJob> Subscribe(CancellationToken cancellationToken) => _channel.Reader.ReadAllAsync(cancellationToken);
}