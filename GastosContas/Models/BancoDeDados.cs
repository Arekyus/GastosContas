using Microsoft.EntityFrameworkCore;

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
