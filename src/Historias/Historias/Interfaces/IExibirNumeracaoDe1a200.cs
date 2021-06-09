using Historias.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Historias.Interfaces
{
    public interface IExibirNumeracaoDe1a200
    {
        ICollection<ResultadoProcessadoDto> Executar();
    }
}
