using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System.Reflection;
using ValorFuturo.Models;

namespace ValorFuturo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.ValorFuturo = 0;
            return View();

        }

        [HttpPost]
        public IActionResult Index(ValorFuturoModel valorFuturo)
        {
            if (ModelState.IsValid)
            {
                ViewBag.ValorFuturo = valorFuturo.CalcularValorFuturo();
            }

            else
            {
                ViewBag.ValorFuturo = 0;
            }
            
            return View(valorFuturo);

        }
    }
}
