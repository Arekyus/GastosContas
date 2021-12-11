using GastosContas.Areas.Identity.Data;
using GastosContas.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(GastosContas.Areas.Identity.IdentityHostingStartup))]
namespace GastosContas.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<GastosContasContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("GastosContasContextConnection")));

                services.AddDefaultIdentity<GastosContasUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<GastosContasContext>();
            });
        }
    }
}