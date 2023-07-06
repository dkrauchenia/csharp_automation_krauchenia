namespace CSharpOOP3
{
    public static class ScooterHelper //Task 6. Creating a static helper class
    {
        public static void CountPrice(Scooter windSurfer)
        {
            Console.WriteLine("Enter the price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            double finalPrice = price + (price * 0.05);

            Console.WriteLine($"Final price (including tax): { finalPrice}");
        }

        public static void SetUsage(Scooter windSurfer)
        {
            Console.WriteLine($"Is the {windSurfer.Model} used? (true/false): ");
            bool isUsed = Convert.ToBoolean(Console.ReadLine());

            windSurfer.IsUsed = isUsed;

            if (isUsed)
            {
                Console.WriteLine($"The {windSurfer.Model} is not new");
            }
            else
            {
                Console.WriteLine($"The {windSurfer.Model} is new");
            }
        }
    }
}
