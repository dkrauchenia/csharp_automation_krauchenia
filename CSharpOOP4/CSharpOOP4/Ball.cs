namespace CSharpOOP4
{
    public class Ball : Shape
    {
        private double _radius;

        public Ball(string name, double radius) : base(name)
        {
            _radius = radius;
        }

        public override double CalculateVolume()
        {
            return (4 / 3) * Math.PI * Math.Pow(_radius, 3);
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Radius: {_radius}");
            Console.WriteLine($"Volume: {CalculateVolume()}");
        }
    }
}
