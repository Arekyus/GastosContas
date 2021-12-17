using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace GastosContas.Controllers
{
    [Authorize]
    public class RelatoriosController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            var mes = DateTime.Today.Month;
            var ano = DateTime.Today.Year;
            var quantidadeDias = DateTime.DaysInMonth(ano, mes);

            var dias = new List<int>();

            for (var dia = 1; dia <= quantidadeDias; dia++)
            {
                dias.Add(dia);  
            }

            ViewBag.Dias = dias;
            ViewBag.Mes = mes;
            ViewBag.Ano = ano;

            return View();
        }

    }
}
