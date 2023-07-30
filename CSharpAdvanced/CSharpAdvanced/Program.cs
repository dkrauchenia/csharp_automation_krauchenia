using CSharpAdvanced;

class Program
{
    static void Main()
    {
        #region Task 1
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        int firstNumber = GetFirstElement(numbers);
        Console.WriteLine($"The first number is: {firstNumber}");

        List<string> names = new List<string> { "John", "Jane", "Alice" };
        string firstName = GetFirstElement(names);
        Console.WriteLine($"The first name is: {firstName}");
        #endregion

        #region Task 2
        var rose = new Rose() { Color = "Red", Price = 2.5 };
        var chamomile = new Chamomile() { Color = "White", Price = 1.5 };

        Console.WriteLine("Enter the number of roses: ");
        int roseCount = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of chamomiles: ");
        int chamomileCount = int.Parse(Console.ReadLine());

        double chamomileBoquetPrice = CountBoquetPrice(chamomile, chamomileCount);
        double roseBoquetPrice = CountBoquetPrice(rose, roseCount);
        double total = chamomileBoquetPrice + roseBoquetPrice;

        Console.WriteLine("Task 2. Receipt:");
        PrintReceiptLine(rose, roseCount, roseBoquetPrice);
        PrintReceiptLine(chamomile, chamomileCount, chamomileBoquetPrice);
        Console.WriteLine($"TOTAL: {total}");
        #endregion

        #region Task 3
        var upgrader = new FlowerUpgrader<Flower>();

        Console.WriteLine("Repaint a rose into: ");
        string newRoseColor = Console.ReadLine();
        upgrader.UpgradeFlower(rose, newRoseColor);

        Console.WriteLine("Repaint a chamomile into: ");
        string newChamomileColor = Console.ReadLine();
        upgrader.UpgradeFlower(chamomile, newChamomileColor);

        double upgradedRosePrice = rose.Price;
        double upgradedChamomilePrice = chamomile.Price;
        double upgradedChamomileBoquetPrice = CountBoquetPrice(chamomile, chamomileCount);
        double upgradedRoseBoquetPrice = CountBoquetPrice(rose, roseCount);
        double totalUpgraded = upgradedRoseBoquetPrice + upgradedChamomileBoquetPrice;

        Console.WriteLine("Task 3. Receipt for repainted flowers:");
        PrintReceiptLine(rose, upgradedRosePrice);
        PrintReceiptLine(chamomile, upgradedChamomilePrice);
        Console.WriteLine($"TOTAL: {totalUpgraded}");
        #endregion
    }

    static T GetFirstElement<T>(List<T> list) //Task 1. 
    {
        if (list.Count > 0)
        {
            return list[0];
        }

        throw new ArgumentException("The list is empty.");
    }

    static double CountBoquetPrice<T> (T flower, int count) where T : Flower //Task 2.
     {
            return flower.Price * count;
     }

     static void PrintReceiptLine<T>(T flower, int count, double totalPrice) where T : Flower //Task 2.
    {
        Console.WriteLine($"Flower:{flower.Name} Quantity:{count} Cost: {totalPrice} $.");
    }

    static void PrintReceiptLine<T>(T flower, double totalPrice) where T : Flower //Task 3.
    {
        Console.WriteLine($"Flower:{flower.Name} New color:{flower.Color}, Cost: {totalPrice} $.");
    }


}
