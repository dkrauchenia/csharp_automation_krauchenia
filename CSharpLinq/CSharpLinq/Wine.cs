namespace CSharpLinq
{
    public class Wine
    {
        public string Color { get; set; }
        public string Name { get; set; }
        public double Alcohol { get; set; }
        public string Region { get; set; }

        public Wine(string color, string name, double alcohol, string region)
        {
            Color = color;
            Name = name;
            Alcohol = alcohol;
            Region = region;
        }
    }
}
