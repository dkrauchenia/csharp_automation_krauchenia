using CSharpOOP3;

static class Program
{
    static void Main()
    {
        //Task 2. Operation with properties from Task 1
        Scooter speedRun = new Scooter();
        //speedRun.Model = "Upgraded Speed Runner"; //Error line
        speedRun.Speed = 25;

        Console.WriteLine($"The scooter model is {speedRun.Model}");
        //Console.WriteLine($"The scooter speed is {speedRun.Speed}"); //Error line

        Scooter.EngineType = "Electric"; //Task 4. Adding value to a static field
        Scooter.DisplayType(); //Task 5. Calling a static method

        ScooterHelper.CountPrice(speedRun); //Task 7. Calling static methods from a static class
        ScooterHelper.SetUsage(speedRun);
    }
}
