using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPatterns
{
    public class ExtraLoudGigantosaurusDecorator : IGigantosaurus //Decorator class that makes roar extra loud
    {
        private IGigantosaurus _gigantosaurus;

        public ExtraLoudGigantosaurusDecorator(IGigantosaurus gigantosaurus)
        {
            _gigantosaurus = gigantosaurus;
        }

        public void Roar()
        {
            Console.WriteLine("He can also make an extra loud roar: ROOOAAAAR!");
        }
    }
}
