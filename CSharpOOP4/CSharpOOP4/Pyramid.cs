namespace CSharpOOP4
{
    public class Pyramid : Shape
    {
        private double _height;
        private double _side;

        public Pyramid(string name, double height, double side) : base(name)
        {
            _height = height;
            _side = side;
        }

        public override double CalculateVolume()
        {
            return Math.Pow(_side, 2) * _height / 3;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Height: {_height}");
            Console.WriteLine($"Side: {_side}");
            Console.WriteLine($"Volume: {CalculateVolume()}");
        }
    }
}
