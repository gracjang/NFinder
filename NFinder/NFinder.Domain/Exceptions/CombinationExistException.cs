namespace NFinder.Domain.Exceptions;

public class CombinationExistException : DomainException
{
    public CombinationExistException(string value) : base($"Combination: {value} exist.")
    {
    }
}