namespace CSharpPatterns
{
    public class Gigantosaurus : IGigantosaurus //Class which is inherited from IGigantosaurus interface with Roar method implementation
    {
        public void Roar()
        {
            Console.WriteLine("Gigantosaurus says \"Rrr!\"");
        }
    }
}
