namespace NFinder.Domain.Exceptions;

public sealed class InvalidObjectIdException : DomainException
{
    public object Id { get; }

    public InvalidObjectIdException(object id) : base($"Cannot set Id: {id} as domain object identifier.") => Id = id;
}