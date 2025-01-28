using Microsoft.AspNetCore.Mvc;

namespace Práctica_1___Grupo__8.Controllers
{
    public class AutenticacionController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult RecuperarContrasennia()
        {
            return View();
        }
    }
}
