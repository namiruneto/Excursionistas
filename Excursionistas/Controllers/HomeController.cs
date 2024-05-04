using Excursionistas.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Excursionistas.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // Ejemplo: Crear una instancia de Excursion y pasarla a la vista
            var excursion = new Excursion
            {
                Id = 1,
                Nombre = "Excursión a la montaña",
                Descripcion = "Una emocionante excursión a la cima de la montaña",
                Fecha = DateTime.Now.AddDays(7)
            };

            return View(excursion);
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
