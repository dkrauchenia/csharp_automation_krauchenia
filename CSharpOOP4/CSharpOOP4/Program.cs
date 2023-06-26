using CSharpOOP4;

class Program
{
    static void Main()
    {
        #region Ball
        Console.WriteLine("Enter the radius of the ball");
        double ballRadius = Double.Parse(Console.ReadLine());
        
        Ball ball = new Ball("Ball", ballRadius);
        ball.ShowInfo();

        Console.WriteLine();
        #endregion

        #region Pyramid
        Console.WriteLine("Enter the pyramid height");
        double pyramidHeight = Double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the pyramid side length");
        double pyramidSide = Double.Parse(Console.ReadLine());

        Pyramid pyramid = new Pyramid("Pyramid", pyramidHeight, pyramidSide);
        pyramid.ShowInfo();

        Console.WriteLine();
        #endregion

        # region Cylinder
        Console.WriteLine("Enter the cylinder height");
        double cylinderHeight = Double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the radius of the cylinder");
        double cylinderRadius = Double.Parse(Console.ReadLine());

        Cylinder cylinder = new Cylinder("Cylinder", cylinderHeight, cylinderRadius);
        cylinder.ShowInfo();
        #endregion

    }
}