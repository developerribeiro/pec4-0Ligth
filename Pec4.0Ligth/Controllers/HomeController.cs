using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pec4._0Ligth.Models.ViewModels;

namespace Pec4._0Ligth.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Pec 4.0 Ligth Sistema de Simulação de Evolução de Rebanho";
            ViewData["Desenvolvedor"] = "Thiago Ribeiro da Silva";
            ViewData["email"] = "developerribeiro@gmail.com";
            ViewData["Telefone"] = "(62)98114-5542";
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            

            return View();
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
