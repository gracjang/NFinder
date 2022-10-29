namespace NFinder.Domain.ValueObjects;

using NFinder.Domain.Exceptions;

public sealed record Combination
{
    public string Value { get; }

    public Combination(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new InvalidCombinationException();
        }

        Value = value;
    }

    public static implicit operator string(Combination combination) => combination.Value;
    public static implicit operator Combination(string combination) => new(combination);
}