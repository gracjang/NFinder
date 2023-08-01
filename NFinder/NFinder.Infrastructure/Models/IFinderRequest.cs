namespace NFinder.Infrastructure.Models;

using MediatR;

public interface IFinderRequest<out TResponse> : IRequest<TResponse> where TResponse : ResponseBase
{
}