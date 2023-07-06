using CSharpException;

static class Program
{
    static void Main()
    {
        Triangle triangle = new Triangle();

        try
        {
            triangle.ReadSides();
            triangle.ValidateTriangle();
        }
        catch (TriangleException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

    }
}

