using System.Numerics;

new Homework_3().Method_1();

class Homework_3
{
    public void Method_1()
    {
        Console.WriteLine("Enter the number: ");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("Tutti");
        }
        else if (number % 5 == 0)
        {
            Console.WriteLine("Frutti");
        }
        else if (number % 2 == 0 && number % 5 == 0)
        {
            Console.WriteLine("Tutti-Frutti");
        }
        else
        {
            Console.WriteLine($"The {number} can't be divided by 2 or by 5");
        }
    }

    public void Method_2()
    {
        Console.WriteLine("Enter the first number: ");
        int number1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number: ");
        int number2 = int.Parse(Console.ReadLine());

        if (number1 >= number2)

            Console.WriteLine("Error: the first number should be less then the second number!");

        else

            for (int number = number1; number <= number2; number++)

                if (number % 2 == 0)
                {
                    Console.WriteLine("Tutti");
                }
                else if (number % 5 == 0)
                {
                    Console.WriteLine("Frutti");
                }
                else if (number % 2 == 0 && number % 5 == 0)
                {
                    Console.WriteLine("Tutti-Frutti");
                }
                else
                {
                    Console.WriteLine($"The {number} can't be divided by 2 or by 5");
                }
    }
    public void Method_3()
    {
        Console.WriteLine("Enter the first number: ");
        int number1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number: ");
        int number2 = int.Parse(Console.ReadLine());

        int minNumber;
        int maxNumber;

        if (number1 < number2)
        {
            minNumber = number1;
            maxNumber = number2;
        }
        else
        {
            minNumber = number2;
            maxNumber = number1;
        }

        Console.WriteLine($"Minimum value: {minNumber}");
        Console.WriteLine($"Maximum value: {maxNumber}");

        for (int number = minNumber; number <= maxNumber; number++)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("Tutti");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Frutti");
            }
            else if (number % 2 == 0 && number % 5 == 0)
            {
                Console.WriteLine("Tutti-Frutti");
            }
            else
            {
                Console.WriteLine($"The {number} can't be divided by 2 or by 5");
            }
        }

    }

}
