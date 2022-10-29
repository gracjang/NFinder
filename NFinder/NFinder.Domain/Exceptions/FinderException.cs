namespace NFinder.Domain.Exceptions;

public abstract class FinderException : Exception
{
    protected FinderException(string message) : base(message) {}
}