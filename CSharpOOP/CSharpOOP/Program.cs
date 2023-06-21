#region Task_1
//Console.WriteLine("Enter the quantity of items: ");
//int quantity = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter the unit price: ");
//double unitPrice = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Enter the discount (%): ");
//double discount = Convert.ToDouble(Console.ReadLine());

//double totalAmount = new Homework_1().CalculateTotalAmount(quantity, unitPrice, discount);
//Console.WriteLine($"Total amount: {totalAmount}");
#endregion

#region Task_2
//Console.WriteLine("Enter the 1st item name: ");
//string itemName1 = Console.ReadLine();

//Console.WriteLine("Enter the 2nd item name: ");
//string itemName2 = Console.ReadLine();

//Console.WriteLine("Enter the 3rd item name: ");
//string itemName3 = Console.ReadLine();

//Console.WriteLine($"Enter the quantity of the {itemName1}: ");
//int quantity1 = int.Parse(Console.ReadLine());

//Console.WriteLine($"Enter the quantity of the {itemName2}: ");
//int quantity2 = int.Parse(Console.ReadLine());

//Console.WriteLine($"Enter the quantity of the {itemName3}: ");
//int quantity3 = int.Parse(Console.ReadLine());

//Console.WriteLine($"Enter the unit price for the {itemName1}: ");
//double unitPrice1 = double.Parse(Console.ReadLine());

//Console.WriteLine($"Enter the unit price for the {itemName2}: ");
//double unitPrice2 = double.Parse(Console.ReadLine());

//Console.WriteLine($"Enter the unit price for the {itemName3}: ");
//double unitPrice3 = double.Parse(Console.ReadLine());

//Console.WriteLine("Enter the discount (%): ");
//double discount = double.Parse(Console.ReadLine());

//string receipt1 = new Homework_1().CreateReceipt(itemName1, unitPrice1, discount);
//string receipt2 = new Homework_1().CreateReceipt(itemName2, unitPrice2, discount);
//string receipt3 = new Homework_1().CreateReceipt(itemName3, unitPrice3, discount);

//double total1 = new Homework_1().CalculateTotalAmount(quantity1, unitPrice1, discount);
//double total2 = new Homework_1().CalculateTotalAmount(quantity2, unitPrice2, discount);
//double total3 = new Homework_1().CalculateTotalAmount(quantity3, unitPrice3, discount);
//double finalPrice = total1 + total2 + total3;

//new Homework_1().CreateFinalReceipt(receipt1, receipt2, receipt3, finalPrice);

#endregion

#region Task_3
//Console.WriteLine("Enter the 1st item name: ");
//string itemName1 = Console.ReadLine();

//Console.WriteLine("Enter the 2nd item name: ");
//string itemName2 = Console.ReadLine();

//Console.WriteLine("Enter the 3rd item name: ");
//string itemName3 = Console.ReadLine();

//Console.WriteLine($"Enter the quantity of the {itemName1}: ");
//int quantity1 = int.Parse(Console.ReadLine());

//Console.WriteLine($"Enter the quantity of the {itemName2}: ");
//int quantity2 = int.Parse(Console.ReadLine());

//Console.WriteLine($"Enter the quantity of the {itemName3}: ");
//int quantity3 = int.Parse(Console.ReadLine());

//Console.WriteLine($"Enter the unit price for the {itemName1}: ");
//double unitPrice1 = double.Parse(Console.ReadLine());

//Console.WriteLine($"Enter the unit price for the {itemName2}: ");
//double unitPrice2 = double.Parse(Console.ReadLine());

//Console.WriteLine($"Enter the unit price for the {itemName3}: ");
//double unitPrice3 = double.Parse(Console.ReadLine());

//Console.WriteLine("Enter the discount (%): ");
//double discount = double.Parse(Console.ReadLine());

//string receipt1 = new Homework_1().CreateReceipt(itemName1, unitPrice1, discount, quantity1);
//string receipt2 = new Homework_1().CreateReceipt(itemName2, unitPrice2, discount, quantity2);
//string receipt3 = new Homework_1().CreateReceipt(itemName3, unitPrice3, discount, quantity3);

//double total1 = new Homework_1().CalculateTotalAmount(quantity1, unitPrice1, discount);
//double total2 = new Homework_1().CalculateTotalAmount(quantity2, unitPrice2, discount);
//double total3 = new Homework_1().CalculateTotalAmount(quantity3, unitPrice3, discount);
//double finalPrice = total1 + total2 + total3;

//new Homework_1().CreateFinalReceipt(receipt1, receipt2, receipt3, finalPrice);
#endregion

#region Task_4
//Console.WriteLine("Enter side 1 length: ");
//double side1 = double.Parse(Console.ReadLine());

//Console.WriteLine("Enter side 2 length: ");
//double side2 = double.Parse(Console.ReadLine());

//Console.WriteLine("Enter side 3 length: ");
//double side3 = double.Parse(Console.ReadLine());

//Console.WriteLine("Enter side 4 length: ");
//double side4 = double.Parse(Console.ReadLine());

//Console.WriteLine("Enter side 5 length: ");
//double side5 = double.Parse(Console.ReadLine());

//double trianglePerimeter = new Homework_1().CalculatePerimeter(side1, side2, side3);
//double rectanglePerimeter = new Homework_1().CalculatePerimeter(side1, side2, side3, side4);
//double pentagonPerimeter = new Homework_1().CalculatePerimeter(side1, side2, side3, side4, side5);

//Console.WriteLine($"Triangle perimeter is {trianglePerimeter}");
//Console.WriteLine($"Rectangle perimeter is {rectanglePerimeter}");
//Console.WriteLine($"Pentagon perimeter is {pentagonPerimeter}");

#endregion

#region Task_5
//Console.WriteLine("Enter a side length of the triangle: ");
//double sideLength = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Enter the triangle height: ");
//double height = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Enter the circle radius: ");
//double radius = Convert.ToDouble(Console.ReadLine());

//double triangleArea = new Homework_1().CalculateArea(sideLength, height);
//Console.WriteLine($"Area of the triangle is {triangleArea}");

//double circleArea = new Homework_1().CalculateArea(radius);
//Console.WriteLine($"Area of the circle is {circleArea}");
#endregion

#region Task_6
/* Encapsulation: A bank account hides information about the account and transactions, providing access only through specific operations.
 * Inheritance: Different animal species inherit common characteristics and properties from their parent species.
 * Polymorphism: A media player has a "play" method that can work with different types of media files.
 * Abstraction: Mobile phone users can use an interface to interact with some of the functions, but it's not necessary to understand the whole complexity of software and hardware
 */
#endregion

class Homework_1
{
    public double CalculateTotalAmount(int quantity, double unitPrice, double discount)
    {
        double price = quantity * unitPrice;
        double discountFraction = discount / 100;
        double amountWithDiscount = price * (1 - discountFraction);
        return amountWithDiscount;
    }

    public string CreateReceipt(string itemName, double unitPrice, double discount, int quantity = 2)
    {
        double totalAmount = CalculateTotalAmount(quantity, unitPrice, discount);
        string receipt = $"Item: {itemName}, Quantity: {quantity}, Price per unit: {unitPrice:C}, Discount: {discount}%, Total amount for {itemName}: {totalAmount:C}";
        return receipt;
    }

    public void CreateFinalReceipt(string receipt1, string receipt2, string receipt3, double finalPrice)
    {
        Console.WriteLine($"{receipt1}");
        Console.WriteLine($"{receipt2}");
        Console.WriteLine($"{receipt3}");
        Console.WriteLine($"TOTAL: {finalPrice:C}");
    }

    public double CalculatePerimeter(params double[] sides)
    {
        double perimeter = 0;
        foreach (double side in sides)
        {
            perimeter += side;
        }
        return perimeter;
    }

    public double CalculateArea(double sideLength, double height)   // Calculating the area of a triangle
    {
        return 0.5 * sideLength * height;
    }

    public double CalculateArea(double radius) // Calculating the area of a circle
    {
        return Math.PI * Math.Pow(radius, 2);
    }

}


