namespace Animals
{
    public abstract class Animal : IAnimal
    {
        private string _name {  get; set; }
        private int _age { get; set; }

        public Animal(string name, int age)
        {
            _name = name;
            _age = age;
        }
        public abstract void MakeSound();
        public void Eat()
        {
            Console.WriteLine($"{_name} is eating.");
        }

        public abstract void Sleep();
        public abstract void Move();
    }
}
