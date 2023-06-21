namespace CSharpOOP2
{
    public class Scooter        //Task 1. Creating class
    {
        //Task 2. Adding class field
        public string Model; 
        public int Year = 2019;
        public double Price;
        public bool IsElectric;


        public void IncreasePriceOrPrint() //Task 3. Creating method, which increases price of a scooter if it's electric
        {
            if (IsElectric)
            {
                Price *= 0.5;
                Console.WriteLine($"Price is modified: {Price}");
            }
            else
            {
                Console.WriteLine($"Model name: {Model}");
                Console.WriteLine($"Year of manufacture: {Year}");
                Console.WriteLine($"Price: {Price}");
                Console.WriteLine($"Has electric engine: {IsElectric}");
            }
        }

        public Scooter(string model, int year, double price, bool isElectric) //Task 6. Creating a constructor, which initializes all class fields
        {
            Model = model;
            Year = year;
            Price = price;
            IsElectric = isElectric;
        }

        public Scooter() //Task 7. Creating empty constructor
        {

        }

        public Scooter(string model, double price) //Task 8. Creating constructor with 2 fields
        {
            Model = model;
            Price = price;
        }

        private void PrintScooter() //Task 11. Creating method with private modifier 
        {
            Console.WriteLine($"The Scooter has following characteristics: Model name: {Model}, price: {Price}, year of manufacture: {Year}; presence of electic engine: {IsElectric}");
        }

        internal void DisplayScooterInfo() //Task 11. Creating method with internal modifier
        {
            Console.WriteLine("Info about your Scooter:");
            Console.WriteLine($"Model name: {Model}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Year of manufacture: {Year}");
            Console.WriteLine($"Has an electric engine: {IsElectric}");
        }
        
    }
}
