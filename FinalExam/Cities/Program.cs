class Program
{
    static void Main()
    {
        List<string> cities = new List<string> { "Baranavichy", "Vileika", "Navahrudak", "Pinsk" };

        var citiesWithEvenLength = cities.Where(city => city.Length % 2 == 0).Select(city => "T" + city.Substring(1)).Select(city => city.Substring(0, 3)).ToList();

        foreach (var city in citiesWithEvenLength)
        {
            Console.WriteLine(city);
        }
    }
}
