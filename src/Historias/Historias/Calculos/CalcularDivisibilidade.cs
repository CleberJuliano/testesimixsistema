using Dominio;
using Historias.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Historias.Calculos
{
    public class CalcularDivisibilidade : ICalcularDivisibilidade
    {
        public string Executar(Numero numero)
        {
            if (numero.DivisivilPor3e5())
                return "Z";
            else if (numero.DivisivelPor3())
                return "X";
            else if (numero.DivisivilPor5())
                return "Y";
            else
                return numero.Valor.ToString();
        }
    }
}
