namespace CSharpOOP4
{
    public abstract class Shape
    {
        private string _name;
        
        public Shape(string name)
        {
            _name = name;
        }

        public abstract double CalculateVolume();

        public virtual void ShowInfo()
        {
            Console.WriteLine($"The figure is {_name}");
        }
    }
}
