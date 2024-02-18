using System.Diagnostics;

namespace TypePatternMatchingOnVisitors;

public static class ValidationHelper
{
    public static bool IsValid(IValue value)
    {
        return value switch
        {
            StringValue stringValue => !string.IsNullOrWhiteSpace(stringValue.Value),
            NumericValue numericValue => numericValue.Value >= 0,
            _ => throw new UnreachableException()
        };
    }
}