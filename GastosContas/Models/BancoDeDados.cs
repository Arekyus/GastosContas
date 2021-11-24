using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GastosContas.Models
{
    public class BancoDeDados : DbContext
    {
       
        public DbSet<Gasto> Gastos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=GastosContas;Integrated Security=True");
        }
    }
}
