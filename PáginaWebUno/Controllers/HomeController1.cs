using Microsoft.AspNetCore.Mvc;

namespace PáginaWebUno.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
