namespace NFinder.Infrastructure.Models;

public abstract class ResponseBase
{
    public string Error { get; set; }
}

public sealed class Error
{
    public string Code { get; set; }

    public string Message { get; set; }
}