namespace CSharpException
{
    public class Triangle
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public double SideA
        {
            get { return sideA; }
            set { sideA = value; }
        }

        public double SideB
        {
            get { return sideB; }
            set { sideB = value; }
        }

        public double SideC
        {
            get { return sideC; }
            set { sideC = value; }
        }


        public void ValidateTriangle()
        {

            if (SideA >= SideB + SideC || SideB >= SideA + SideC || SideC >= SideA + SideB)
            {
                throw new TriangleException("The sum of any two sides of a triangle must be greater than the third side.");
            }
            else
            {
                Console.WriteLine($"Sides of triangle: {SideA}, {SideB}, {SideC}");
            }
        }

        public void ReadSides()
        {
            Console.WriteLine("Enter Side A length: ");
            double inputA;
            while (!double.TryParse(Console.ReadLine(), out inputA) || inputA <= 0)
            {
                Console.WriteLine("Invalid input. Side A must be a positive number. Try again: ");
            }
            SideA = inputA;

            Console.WriteLine("Enter Side B length: ");
            double inputB;
            while (!double.TryParse(Console.ReadLine(), out inputB) || inputB <= 0)
            {
                Console.WriteLine("Invalid input. Side B must be a positive number. Try again: ");
            }
            SideB = inputB;

            Console.WriteLine("Enter Side C length: ");
            double inputC;
            while (!double.TryParse(Console.ReadLine(), out inputC) || inputC <= 0)
            {
                Console.WriteLine("Invalid input. Side C must be a positive number. Try again: ");
            }
            SideC = inputC;
        }

    }
}
