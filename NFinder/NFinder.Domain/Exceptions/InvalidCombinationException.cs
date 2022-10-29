namespace NFinder.Domain.Exceptions;

public class InvalidCombinationException : FinderException
{
    public InvalidCombinationException() : base("Invalid string combination.")
    {
    }
}