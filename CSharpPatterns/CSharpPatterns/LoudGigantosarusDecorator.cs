namespace CSharpPatterns
{
    public class LoudGigantosarusDecorator : IGigantosaurus //Decorator class that makes roar louder
    {
        private IGigantosaurus _gigantosaurus;

        public LoudGigantosarusDecorator(IGigantosaurus gigantosaurus)
        {
            _gigantosaurus = gigantosaurus;
        }

        public void Roar()
        {
           Console.WriteLine("Sometimes he makes louder roar: RRR!");
        }
    }
}
