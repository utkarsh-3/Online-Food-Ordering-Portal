using System;
using EatFit.Areas.Identity.Data;
using EatFit.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(EatFit.Areas.Identity.IdentityHostingStartup))]
namespace EatFit.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<EatFitContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("EatFitContextConnection")));

                //services.AddDefaultIdentity<EatFitUser>(options => options.SignIn.RequireConfirmedAccount = true)
                 //   .AddEntityFrameworkStores<EatFitContext>();
            });
        }
    }
}