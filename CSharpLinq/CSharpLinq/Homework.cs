namespace CSharpLinq
{
    public class Homework
    {
        public void Task_1()
        {
            var numbers = new List<int>() { 3, 23, 76, 1, 580, 18, 333, 45, 7, 321 };

            var numsDivByThree = from num in numbers
                                 where num % 3 == 0
                                 select num;

            Console.WriteLine("Task 1.");
            Console.WriteLine("Numbers divisible by 3:");
            foreach (int num in numsDivByThree)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();
        }

        public void Task_2()
        {
            var numbers = new List<int>() { 7, -8, 9, -10, 11, 12, -13, 14, -15 };

            var negativeNumbersLessThanTen = numbers.Where(num => num < 0 || num < 10);

            Console.WriteLine("Task 2.");
            Console.WriteLine("Negative numbers less than 10:");

            foreach (int num in negativeNumbersLessThanTen)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();
        }

        public void Task_3()
        {
            var flowers = new List<string> { "Lily", "Iris", "Dafodill", "Poppy", "Rose" };

            var namesEven = from name in flowers
                            where name.Length % 2 == 0
                            orderby name
                            select name;

            Console.WriteLine("Task 3.");
            Console.WriteLine("Names of flowers with even count of letters:");

            foreach (string name in namesEven)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();
        }

        public void Task_4()
        {
            var cities = new List<string> { "Paris", "Lisbon", "Hamburg", "Warsaw", "Honkong", "London" };

            char startLetter = 'L';
            char endLetter = 'g';

            var filteredCities = cities.Where(city => city.StartsWith(startLetter.ToString()) || city.EndsWith(endLetter.ToString()));

            Console.WriteLine("Task 4.");
            Console.WriteLine($"Cities starting with '{startLetter}' or ending with '{endLetter}':");

            foreach (string city in filteredCities)
            {
                Console.WriteLine(city);
            }
            Console.WriteLine();
        }

        public void Task_5()
        {
            Console.WriteLine("Task 5");
            Console.WriteLine("Type a sentence:");
            string input = Console.ReadLine();

            List<string> words = input.Split(' ').ToList();

            List<string> uppercaseWords = words.Where(word => !string.IsNullOrEmpty(word) && char.IsUpper(word[0])).ToList();

            Console.WriteLine("Words with a capital letter:");
            foreach (string word in uppercaseWords)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine();
        }

        public void Task_6()
        {
            var numbers = new List<int>() { 5, 12, 75, 12, 98, 5, 10, 8, 77, 98 };

            var numbersUnique = numbers.Distinct().Reverse();

            Console.WriteLine("Task 6.");
            Console.WriteLine("Unique numbers:");
            Console.WriteLine(string.Join(" ", numbersUnique));
            Console.WriteLine();
        }

        public void Task_7()
        {
            var numbers = new List<int>() { 125, 67, 45, 34, 118, 876, 3, 378, 5, 39 };

            Console.WriteLine("Task 7.");
            Console.WriteLine("Enter a number: ");
            int input = int.Parse(Console.ReadLine());

            bool numIsInCollection = numbers.Contains(input);
            if (numIsInCollection)
            {
                Console.WriteLine("The number is in the collection");
            }
            else
            {
                Console.WriteLine("The number is not in the collection");
            }
            Console.WriteLine();
        }

        public void Task_8()
        {
            List<string> strings = new List<string> { "What", "a", "wonderful", "World" };

            int sumOfLengths = strings.Sum(s => s.Length);

            Console.WriteLine("Task 8.");
            Console.WriteLine($"Sum of all the elements' lengths: {sumOfLengths}");

            if (sumOfLengths > 5)
            {
                Console.WriteLine($"The First element: {strings.First()}");
                Console.WriteLine($"The Last element: {strings.Last()}");
            }
            Console.WriteLine();
        }

        public void Task_9()
        {
            List<string> colors = new List<string> { "Red", "White", "Rose" };
            
            List<Wine> wines = colors.Select(color => new Wine(color,"Name", 0.0, "Region")).ToList();

            Console.WriteLine("Task 9.");
            Console.WriteLine("List of Wines by color: ");
            foreach (Wine wine in wines)
            {
                Console.WriteLine($"Color: {wine.Color}, Name: {wine.Name}, Alcohol: {wine.Alcohol}, Region: {wine.Region}");
            }
            Console.WriteLine();
        }

        public void Task_10()
        {
            List<Wine> wines = new List<Wine>
            {
                new Wine("Red", "Merlot", 12.5, "France"),
                new Wine("White", "Chardonnay", 13.0, "California"),
                new Wine("Rose", "Grenache", 11.0, "Spain")
            };

            List<string> colors = wines.Select(wine => wine.Color).ToList();

            Console.WriteLine("Task 10.");
            Console.WriteLine("List of Wine colors: ");
            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }
        }

    }
}
