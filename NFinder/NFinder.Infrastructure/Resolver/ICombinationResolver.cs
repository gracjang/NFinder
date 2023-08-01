namespace NFinder.Infrastructure.Resolver;

public interface ICombinationResolver
{
    Task<IEnumerable<string>> Resolve(List<char> characters);
}