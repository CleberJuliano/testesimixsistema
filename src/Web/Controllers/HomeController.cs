using Historias.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IExibirNumeracaoDe1a200 exibirNumeracaoDe1A200;

        public HomeController(
            ILogger<HomeController> logger,
            IExibirNumeracaoDe1a200 exibirNumeracaoDe1A200)
        {
            _logger = logger;
            this.exibirNumeracaoDe1A200 = exibirNumeracaoDe1A200;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ExibirResultados()
        {
            var numeracoes = this.exibirNumeracaoDe1A200.Executar();
            return PartialView("_Resultados", numeracoes);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
