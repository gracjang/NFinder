namespace NFinder.Domain.Exceptions;

public sealed class InvalidObjectIdException : FinderException
{
    public object Id { get; }

    public InvalidObjectIdException(object id) : base($"Cannot set Id: {id} as domain object identifier.") => Id = id;
}