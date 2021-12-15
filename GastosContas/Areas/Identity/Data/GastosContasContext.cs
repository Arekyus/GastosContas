using GastosContas.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GastosContas.Data
{
    public class GastosContasContext : IdentityDbContext<GastosContasUser>
    {
        public GastosContasContext(DbContextOptions<GastosContasContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
