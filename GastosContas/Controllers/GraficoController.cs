using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace GastosContas.Controllers
{
    public class GraficoController : Controller
    {
        public ActionResult TotalMes()
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

        public ActionResult EntradaTotalMes()
        {
            return View();
        }
    }
}
