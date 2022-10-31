namespace NFinder.Application.Exceptions;

using NFinder.Domain.Exceptions;

public class NotFoundProcessingJobException : FinderException
{
    public NotFoundProcessingJobException() : base($"Not found any processing jobs.")
    {
    }
}