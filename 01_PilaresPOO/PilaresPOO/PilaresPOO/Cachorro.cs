using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilaresPOO
{
    public class Cachorro : Animal
    {
        public void atacar()
        {
            Console.WriteLine($"{nome} está correndo atrás da moto...");
        }

        public override void emitirSom()
        {
            Console.WriteLine($"{nome} está latindo, au au au...");
        }

    }
}
