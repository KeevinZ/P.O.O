using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilaresPOO
{
    public class Animal
    {
        public string nome;
        private int idade;
        public string tipoAlimentacao;

        public virtual void emitirSom()
        {
            Console.WriteLine($"{nome} está emitindo um som...");
        }

        public void setIdade( int idade )
        {
            if (idade >= 0) 
                this.idade = idade;
        }

        public int getIdade()
        {
            return this.idade;
        }
    }
}
