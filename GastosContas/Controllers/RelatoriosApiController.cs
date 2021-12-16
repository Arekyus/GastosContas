using Microsoft.AspNetCore.Mvc;

namespace GastosContas.Controllers
{

    public class RelatoriosApiController : BaseController
    {

        [HttpGet]
        public string GetById ([FromRoute] string descricao)
        {
            return descricao;
        }



    }
}
