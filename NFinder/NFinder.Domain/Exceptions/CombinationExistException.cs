namespace NFinder.Domain.Exceptions;

public class CombinationExistException : FinderException
{
    public CombinationExistException(string value) : base($"Combination: {value} exist.")
    {
    }
}