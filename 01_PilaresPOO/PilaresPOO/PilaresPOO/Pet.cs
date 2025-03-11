using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilaresPOO
{
    public class Pet
    {
        public string nome;
        public int idade;
        public string tipo;

        public void alimentar()
        {
            Console.WriteLine($"{nome} está se alimentando!");
        }
    }
}
