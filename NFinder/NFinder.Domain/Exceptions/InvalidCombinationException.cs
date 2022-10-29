namespace NFinder.Domain.Exceptions;

public class InvalidCombinationException : DomainException
{
    public InvalidCombinationException() : base("Invalid string combination.")
    {
    }
}