using Historias.Calculos;
using Historias.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<ICalcularDivisibilidade, CalcularDivisibilidade>();
            services.AddScoped<IExibirNumeracaoDe1a200, ExibirNumeracaoDe1a200>();
        }
    }
}
