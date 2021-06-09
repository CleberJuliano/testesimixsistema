using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Numero
    {
        public Numero(int valor)
        {
            Valor = valor;
        }
        public Numero()
        {

        }

        public int Valor { get; private set; }


        public bool DivisivelPor3()
        {
            return ((this.Valor % 3) == 0);
        }
        public bool DivisivilPor5()
        {
            return ((this.Valor % 5) == 0);
        }
        public bool DivisivilPor3e5()
        {
            return ((this.Valor % 3) == 0) && ((this.Valor % 5) == 0);
        }
    }
}
