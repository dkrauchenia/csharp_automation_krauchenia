new Homework_2().Task_1();

class Homework_2
{
    public void Task_1()
    {
        Console.WriteLine("Enter your age");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter your BMI");
        double bodyMassIndex = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter your blood group");
        char bloodGroup = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Do you smoke? (true or false)");
        bool smokingStatus = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine("Your age:" + age);
        Console.WriteLine("Your BMI:" + bodyMassIndex);
        Console.WriteLine("Your blood group" + bloodGroup);
        Console.WriteLine("You smoke: " + smokingStatus);
    }

    public void Task_2()
    {
        Console.WriteLine("In which year Waterloo battle took place?");
        int answer1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Did Napoleon win? (True or False):");
        bool answer2 = bool.Parse(Console.ReadLine());

        Console.WriteLine("Year of the Waterloo battle: " + answer1);
        Console.WriteLine("Napoleon was the winner: " + answer2);
    }
    public void Task_3()
    {
        Console.WriteLine("Enter an integer:");
        string input = Console.ReadLine();
        bool output = int.TryParse(input, out int number);
        if (output)
            Console.WriteLine($"Correct. The integer is {number}");
        else
            Console.WriteLine("Error");
    }

    public void Task_4()
    {
        Console.WriteLine("Enter an integer:");
        int valueA = int.Parse(Console.ReadLine());
        int valueB = valueA * 3;
        int valueC = valueA + valueB;
        Console.WriteLine($"Value A is {valueA}");
        Console.WriteLine($"Value B is {valueB}");
        Console.WriteLine($"Value C is {valueC}");
    }

    public void Task_5()
    {
        string purchaseName1 = "Milk";
        string purchaseName2 = "Cheese";
        string purchaseName3 = "Salmon";
        string purchaseName4 = "Salad";
        string purchaseName5 = "Tomatoes";
        string purchaseName6 = "Wine";

        double prise1 = 3.99;
        double prise2 = 5.99;
        double prise3 = 25.99;
        double prise4 = 2.99;
        double prise5 = 4.99;
        double prise6 = 31.99;

        int quantity1 = 2;
        int quantity2 = 1;
        int quantity3 = 2;
        int quantity4 = 1;
        int quantity5 = 3;
        int quantity6 = 1;

        double cost1 = prise1 * quantity1;
        double cost2 = prise2 * quantity2;
        double cost3 = prise3 * quantity3;
        double cost4 = prise4 * quantity4;
        double cost5 = prise5 * quantity5;
        double cost6 = prise6 * quantity6;

        double totalCost = cost1 + cost2 + cost3 + cost4 + cost5 + cost6;
        double discount = (totalCost - cost6) * 0.15;
        double toPay = totalCost - discount;

        Console.WriteLine("Receipt:");
        Console.WriteLine($"1. {purchaseName1}, amount {quantity1}, cost {cost1}");
        Console.WriteLine($"1. {purchaseName2}, amount {quantity2}, cost {cost2}");
        Console.WriteLine($"1. {purchaseName3}, amount {quantity3}, cost {cost3}");
        Console.WriteLine($"1. {purchaseName4}, amount {quantity4}, cost {cost4}");
        Console.WriteLine($"1. {purchaseName5}, amount {quantity5}, cost {cost5}");
        Console.WriteLine($"1. {purchaseName6}, amount {quantity6}, cost {cost6}");
        Console.WriteLine($"Your 15% discount: {discount}");
        Console.WriteLine($"Note: 15% discount doesn't cover alcohol");
        Console.WriteLine($"TOTAL: {toPay}");
    }

    public void Task_6()
    {
        double a = 7;
        double b = 8;

        double c = a++ * (a + b);
        // 1) (a + b) = (8 + 8)
        // 2) a++ * (a + b) = 7*16 = 112
        // 3) a++ = 7
        double d = --b + a * 2;
        // 1) --b = 8-1 =7
        // 2) a * 2 = 8*2 = 16;
        // 3) --b + a * 2 = 7+16 = 32

        Console.WriteLine(c);
        Console.WriteLine(d);

    }

    public void Task_7_1()
    {
        int a = 5;
        int b = 5;
        Console.WriteLine(a == b);
        Console.WriteLine(b != a);
    }

    public void Task_7_2()
    {
        bool a = true;
        bool b = true;
        bool c = true;

        Console.WriteLine(a && b == c);
        Console.WriteLine(a && b != c);
    }

    public void Task_7_3()
    {
        bool a = false;
        bool b = true;
        bool c = false;

        Console.WriteLine(a || b != c);
        Console.WriteLine(a || b == c);
    }

    public void Task_7_4()
    {
        bool a = false;
        bool b = true;

        Console.WriteLine(a != b);
        Console.WriteLine(a == b);
    }

    public void Task_7_5()
    {
        int a = 5;
        int b = 6;

        Console.WriteLine(a <= b);
        Console.WriteLine(a == b);
    }

    public void Task_8()
    {
        int number = 5;
        object packedNum = number;
        int unpackedNum = (int)packedNum;
        Console.WriteLine("Packed value: " + packedNum);
        Console.WriteLine("Unpacked value: " + unpackedNum);
    }

    public void Task_9() 
    {
        int a = 3;
        short b = 4;

        double c = a;
        byte d = (byte)b;
    }

}


