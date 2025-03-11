using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilaresPOO
{
    public class Gato : Animal
    {
        public override void emitirSom()
        {
            Console.WriteLine($"{nome} está miando, miau, miau...");
        }
    }
}
