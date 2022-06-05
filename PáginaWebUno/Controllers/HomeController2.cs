using Microsoft.AspNetCore.Mvc;

namespace PáginaWebUno.Controllers
{
    public class HomeController2 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
