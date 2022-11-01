namespace NFinder.Application.Exceptions;

using NFinder.Domain.Exceptions;

public class OutOfRangeCombinationCountException : FinderException
{
    public int MaxCombinationRange { get;}
    
    public int UserCombinationCount { get;}
    
    public OutOfRangeCombinationCountException(int maxCombinationRange, int userCombinationCount) 
        : base($"Cannot process job. User combinationCount is too large: {userCombinationCount}. Max range: {maxCombinationRange}")
    {
        MaxCombinationRange = maxCombinationRange;
        UserCombinationCount = userCombinationCount;
    }
}