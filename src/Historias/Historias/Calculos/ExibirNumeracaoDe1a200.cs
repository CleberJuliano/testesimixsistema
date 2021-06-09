using Dominio;
using Historias.Dtos;
using Historias.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Historias.Calculos
{
    public class ExibirNumeracaoDe1a200 : IExibirNumeracaoDe1a200
    {
        private readonly ICalcularDivisibilidade calculcarDivisibilidade;

        public ExibirNumeracaoDe1a200(
            ICalcularDivisibilidade calculcarDivisibilidade)
        {
            this.calculcarDivisibilidade = calculcarDivisibilidade;
        }
        public ICollection<ResultadoProcessadoDto> Executar()
        {
            var valorMaximoParaCalculo = 200;
            var resultadosProcessados = new List<ResultadoProcessadoDto>();

            for (int i = 1; i <= valorMaximoParaCalculo; i++)
            {
                var numeroCalculado = new Numero(i);
                var resultado = this.calculcarDivisibilidade.Executar(numeroCalculado);
                resultadosProcessados.Add(new ResultadoProcessadoDto(resultado));
            }
            return resultadosProcessados;
        }
    }
}
