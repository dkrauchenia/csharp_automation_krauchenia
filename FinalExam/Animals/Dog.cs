namespace Animals
{
    public class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age) { }

        public override void MakeSound()
        {
            Console.WriteLine("Woof-woof");
        }

        public override void Move()
        {
            Console.WriteLine("A dog can run like a mad rabbit");
        }

        public override void Sleep()
        {
            Console.WriteLine("A dog can sleep for 19 hours per day");
        }
    }
}
