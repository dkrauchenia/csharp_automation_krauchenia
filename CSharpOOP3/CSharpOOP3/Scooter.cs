namespace CSharpOOP3
{
    public class Scooter
    {
        public string Model { get; } = "SpeedRunner"; //Task 1. Creating properties. Property for reading only

        private double _speed;

        public double Speed //Task 1. Property for being assigned
        {
            set
            {
                _speed = value;
            }
        }

        private bool _isAvailable; //Task 3. Adding accessors to the field

        public bool IsAvailable
        {
            get 
            { 
                return _isAvailable; 
            }

            private set 
            { 
                _isAvailable = value; 
            }
        }

        public double Price; //Fields for operations in the helper class
        public bool IsUsed;

        public static string EngineType { get; set; } //Task 4. Static field

        public static void DisplayType() //Task 5. Static method
        {
            Console.WriteLine($"The type of scooter is: {EngineType}");
        }


    }
}
