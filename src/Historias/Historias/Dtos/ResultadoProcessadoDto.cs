using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Historias.Dtos
{
    public class ResultadoProcessadoDto
    {
        public ResultadoProcessadoDto(string valor)
        {
            Valor = valor;
        }
        public ResultadoProcessadoDto()
        {

        }

        public string Valor { get; private set; }

        public string ColorirBox()
        {

            if (this.Valor == "Z")
                return "bg-danger";
            else if (this.Valor == "Y")
                return "bg-secondary";
            else if (this.Valor == "X")
                return "bg-primary";
            else
                return string.Empty;
        }
    }
}
