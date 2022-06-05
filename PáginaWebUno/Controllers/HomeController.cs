using Microsoft.AspNetCore.Mvc;
using PáginaWebUno.Models;
using System.Diagnostics;

namespace PáginaWebUno.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Contactenos()
        {
            //DatosContacto dc = new DatosContacto();
            //dc.nombre = "Jeanca";
            //dc.edad = 18;
            //dc.correoElectronico = "jbarberena@edu.upolitecnica.cr";
            //dc.comentario = "Volando voy, volando vengo";
            return View();
           
        }
        [HttpPost] /*Funciona unicamente cuando se envia el formulario */
        public IActionResult Contactenos(DatosContacto DC)
        {
            return View("ContactenosGracias", DC);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}