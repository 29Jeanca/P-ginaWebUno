using Microsoft.AspNetCore.Mvc;
using PáginaWebUno.Models;
namespace PáginaWebUno.Controllers
{
    public class ContactosController : Controller
    {
        List<DatosContacto> datos = new List<DatosContacto>()
        {
            new DatosContacto(){correoElectronico="jbarberena.edu",nombre="Jeanca"},
            new DatosContacto(){correoElectronico="Karim.edu",nombre="Karim"},
            
        };
    
        public IActionResult Index()
        {
            return View(datos);
        }
    }
}
