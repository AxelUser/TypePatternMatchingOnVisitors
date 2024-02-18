namespace TypePatternMatchingOnVisitors;

public interface IValueVisitor<out T>
{
    T Visit(StringValue stringValue);
    T Visit(NumericValue numericValue);
    T Visit(DateTimeValue dateTimeValue);
}

public class ValueValidationVisitor: IValueVisitor<bool>
{
    public static readonly ValueValidationVisitor Instance = new();
    
    public bool Visit(StringValue stringValue) => !string.IsNullOrWhiteSpace(stringValue.Value);
    public bool Visit(NumericValue numericValue) => numericValue.Value >= 0;
    public bool Visit(DateTimeValue dateTimeValue) => dateTimeValue.Value <= DateTimeOffset.UtcNow;
}

