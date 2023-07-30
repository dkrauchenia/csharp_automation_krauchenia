using Test_Krauchenia_18_07_2023;

class Program
{
    static void Main()
    {
        #region Task1
        Console.WriteLine("Task 1.");

        int number;

        Console.WriteLine("Enter a number: ");
        string input = Console.ReadLine();

        bool success = int.TryParse(input, out number);

        if (success)
        {
            Console.WriteLine($"Success: {number}");
        }
        else
        {
            Console.WriteLine("Failure: not a number");
        }
        Console.WriteLine();

        #endregion

        #region Task 2

        /*a) a = 5, b = 5
        b) true, false, true
        c) a = 10, b = 5 */

        #endregion

        #region Task 3
        Console.WriteLine("Task 3.");

        Console.WriteLine("Multiplication table:");
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                int result = i * j;
                Console.Write(result);
            }

            Console.WriteLine();
        }

        Console.WriteLine();
        #endregion

        #region Task 4
        Console.WriteLine("Task 4.");

        Console.WriteLine("Enter student grade:");
        var numberFromConsole = Console.ReadLine();
        int grade = int.Parse(numberFromConsole);

        switch (grade)
        {
            case 4:
                Console.WriteLine("Exam passed satisfactorily!");
                break;
            case 6:
                Console.WriteLine("Exam passed good!");
                break;
            case 8:
                Console.WriteLine("Exam passed excellent!");
                break;
            default:
                Console.WriteLine("Exam failed");
                break;
        }
        Console.WriteLine();
        #endregion

        #region Task 5

        Console.WriteLine("Task 5.");

        int result1 = Multiply(2, 10);
        Console.WriteLine(result1);

        int result2 = Multiply(2);
        Console.WriteLine(result2);

        Console.WriteLine();
        #endregion

        #region Task 6
        Console.WriteLine("Task 6.");

        //Creating an object
        Berry berry1 = new Berry();

        //Modifying the object with properties
        berry1.Weight = 2.5;
        berry1.PricePerKilo = 4.99;

        //Calling the method
        berry1.CalculateTotalCost();

        //Creating an object using the constructor with thwe parameters
        Berry berry2 = new Berry(3.0, 6.99);

        //Calling the method for the second object
        berry2.CalculateTotalCost();

        Console.WriteLine();
        #endregion

        #region Task 7

        Console.WriteLine("Task 7.");

        List<string> purchases = new List<string>()
        {
            "sugar",
            "bananas",
            "milk",
            "flour",
            "eggplants"
        };

        Console.Write("Enter a letter: ");
        char letter = Console.ReadLine().ToLower()[0];

        var filteredPurchases = purchases.Where(str => str.ToLower().Contains(letter));

        Console.WriteLine("Strings containing the letter '{0}':", letter);
        foreach (string str in filteredPurchases)
        {
            Console.WriteLine(str);
        }

        Console.WriteLine();
        #endregion

        #region Task 8

        Console.WriteLine("Task 8.");

        Console.WriteLine("Enter a string:");
        string inputLine = Console.ReadLine();

        string[] words = inputLine.Split(' ');

        Console.WriteLine("Result:");

        foreach (string word in words)
        {
            if (word.Length > 3)
            {
                Console.WriteLine(word);
            }
        }
        Console.WriteLine();
        #endregion


        #region Task 9

        Console.WriteLine("Task 9.");

        List<string> names = new List<string>();

        Console.WriteLine("Enter three names (press Enter after each name:");

        for (int i = 0; i < 3; i++)
        {
            string inputNames = Console.ReadLine();
            names.Add(inputNames);
        }

        names.Sort();

        Console.WriteLine("Sorted list:");

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine();
        #endregion

        #region Task 10
        #endregion
    }

    public static int Multiply(int a, int b) //Task 5.
    {
        return a * b;
    }

    public static int Multiply(int a)
    {
        return a * a;
    }
}
