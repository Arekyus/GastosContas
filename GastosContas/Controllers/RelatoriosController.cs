using Microsoft.AspNetCore.Mvc;

namespace GastosContas.Controllers
{
    public class RelatoriosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
