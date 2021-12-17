using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Dapper.Contrib.Extensions;
using GastosContas.Models;


namespace GastosContas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RelatoriosApiController : ControllerBase
    {
        private IConfiguration _config;

        public RelatoriosApiController(IConfiguration configuration)
        {
            _config = configuration;
        }

        [HttpGet]
        public IEnumerable<Gasto> GetGastos()
        {
            using (SqlConnection conexao = new SqlConnection(
                _config.GetConnectionString("GastosContasContextConnection")))
            {
                return conexao.GetAll<Gasto>();
            }
        }
    }
}