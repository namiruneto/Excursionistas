using Excursionistas.Class;
using Excursionistas.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Newtonsoft.Json;


namespace Excursionistas.Controllers
{
    public class CalcularController : Controller
    {
        private readonly ILogger<CalcularController> _logger;

        public CalcularController(ILogger<CalcularController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public JsonResult GetCalcular(int calorias, int peso)
        {
            Calculate calculate = new Calculate();     

            // Devolver el resultado como JSON
            return Json(JsonConvert.SerializeObject(calculate.MejorCalculo(calorias, peso)));
        }

    }
}
