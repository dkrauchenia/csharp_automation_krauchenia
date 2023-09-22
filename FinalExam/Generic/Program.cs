class Program
{
    static void Main()
    {
        int intValue = 100;
        double doubleValue = 2.5;
        string stringValue = "Some text";

        TypeValue(intValue);
        TypeValue(doubleValue);
        TypeValue(stringValue);
    }
    static void TypeValue<T>(T value)
    {
        Console.WriteLine(value);
    }
}
