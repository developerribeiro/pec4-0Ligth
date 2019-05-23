using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pec4_0Ligth.Models;

namespace Pec4_0Ligth.Controllers
{
    public class SimulacaosController : Controller
    {
        public IActionResult Index()
        {
            List<Simulacao> list = new List<Simulacao>();
            list.Add(new Simulacao { Id = 1, Nome = "Primeira Simulacao",Data=DateTime.Now,Status=1 });
            list.Add(new Simulacao { Id = 1, Nome = "Segunda Simulacao", Data = DateTime.Now ,Status=1});
            return View(list);
        }
    }
}