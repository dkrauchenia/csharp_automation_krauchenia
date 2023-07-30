namespace Test_Krauchenia_18_07_2023
{
    public class Berry
    {
        public double Weight { get; set; }
        public double PricePerKilo { get; set; }

        public Berry() //emply constructor
        {
   
        }

        public Berry(double weight, double pricePerKilo)
        {
            Weight = weight;
            PricePerKilo = pricePerKilo;
        }

        public void CalculateTotalCost()
        {
            double totalCost = Weight * PricePerKilo;
            Console.WriteLine($"Total cost of berries: ${totalCost}");
        }
    }
}
