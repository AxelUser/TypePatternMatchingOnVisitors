namespace TypePatternMatchingOnVisitors;

public interface IValue
{
    T Accept<T>(IValueVisitor<T> visitor);
}

public record StringValue(string? Value): IValue
{
    public T Accept<T>(IValueVisitor<T> visitor) => visitor.Visit(this);
}

public record NumericValue(long Value): IValue
{
    public T Accept<T>(IValueVisitor<T> visitor) => visitor.Visit(this);
}

public record DateTimeValue(DateTimeOffset Value) : IValue
{
    public T Accept<T>(IValueVisitor<T> visitor) => visitor.Visit(this);
}