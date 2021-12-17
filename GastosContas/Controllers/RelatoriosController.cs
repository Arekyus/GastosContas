using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GastosContas.Controllers
{
    [Authorize]
    public class RelatoriosController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

    }
}
