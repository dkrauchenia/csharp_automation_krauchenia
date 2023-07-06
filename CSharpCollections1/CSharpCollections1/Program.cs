using System;

class Program
{
    static void Main()
    {
        #region Task1

        int[] numbers1 = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };

        //Create two empty arrays for even and odd numbers
        int[] evenNumbers = new int[numbers1.Length];
        int[] oddNumbers = new int[numbers1.Length];

        //Counters to track the current position in the new arrays
        int evenCount = 0;
        int oddCount = 0;

        //Iterate over the original array and distribute the numbers into the corresponding arrays
        foreach (int number in numbers1)
        {
            if (number % 2 == 0)
            {
                //Even number
                evenNumbers[evenCount] = number;
                evenCount++;
            }
            else
            {
                //Odd number
                oddNumbers[oddCount] = number;
                oddCount++;
            }
        }

        //Create new arrays with sizes corresponding to the count of even and odd numbers found
        int[] sortedEvenNumbers = new int[evenCount];
        int[] sortedOddNumbers = new int[oddCount];

        //Copy the even and odd numbers to the new arrays
        Array.Copy(evenNumbers, sortedEvenNumbers, evenCount);
        Array.Copy(oddNumbers, sortedOddNumbers, oddCount);

        //Sort the arrays in ascending order
        Array.Sort(sortedEvenNumbers);
        Array.Sort(sortedOddNumbers);

        //Print the sorted arrays
        Console.WriteLine("Sorted array of even numbers:");
        foreach (int evenNumber in sortedEvenNumbers)
        {
            Console.WriteLine(evenNumber);
        }

        Console.WriteLine();

        Console.WriteLine("Sorted array of odd numbers:");
        foreach (int oddNumber in sortedOddNumbers)
        {
            Console.WriteLine(oddNumber);
        }
        #endregion

        #region Task2

        double[] numbers2 = { 2.5, 6.1, 3.8, 9.2, 1.7 };

        //Initialize variables for the minimum and maximum numbers
        double minNumber = numbers2[0];
        double maxNumber = numbers2[0];

        //Find the minimum and maximum numbers in the array
        foreach (double number in numbers2)
        {
            if (number < minNumber)
            {
                minNumber = number;
            }

            if (number > maxNumber)
            {
                maxNumber = number;
            }
        }

        //Calculate the difference between the maximum and minimum numbers
        double difference = maxNumber - minNumber;

        //Print the result
        Console.WriteLine($"Difference between maximum and minimum number: {difference}");

        #endregion

        #region Task3

        List<string> surnames = new List<string>
        {
            "Muller",
            "Petrov",
            "Schmidt",
            "Brown",
            "Dupont"
        };

        surnames.Sort();

        Console.WriteLine("Sorted surnames:");
        foreach (string surname in surnames)
        {
            Console.WriteLine(surname);
        }

        #endregion

        #region Task4 - not done

        #endregion

        #region Task5 - Unfinished task

        //Dictionary<string, string> countryCapitalDictionary = new Dictionary<string, string>();

        //Console.WriteLine("Enter 5 lines in format \"Country : Capital\":");
        //string input = Console.ReadLine();

        //for (int i = 0; i < 5; i++)
        //{
        //    string[] part = input.Split(':');
        //    if (part.Length == 2)
        //    {
        //        string country = part[0];
        //        string capital = part[1];
        //        countryCapitalDictionary[country] = capital;
        //    }

        //}

        #endregion
    }
}