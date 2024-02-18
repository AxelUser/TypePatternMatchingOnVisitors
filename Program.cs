using TypePatternMatchingOnVisitors;

while (true)
{
    Console.Write("Write a property value: ");
    var input = Console.ReadLine();
    var value = Parse(input);
    //Console.WriteLine($"Value '{input}' is valid: " + ValidationHelper.IsValid(value));    
    Console.WriteLine($"Value '{input}' is valid: " + value.Accept(ValueValidationVisitor.Instance));    
}

static IValue Parse(string? value)
{
    if (long.TryParse(value, out var num)) return new NumericValue(num);
    if (DateTimeOffset.TryParse(value, out var dateTime)) return new DateTimeValue(dateTime);
    return new StringValue(value);
}