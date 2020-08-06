using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Studentdatabase_management_system.Data;

[assembly: HostingStartup(typeof(Studentdatabase_management_system.Areas.Identity.IdentityHostingStartup))]
namespace Studentdatabase_management_system.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<StudentDbContext>(options =>
                    options.UseMySql(
                     context.Configuration.GetConnectionString("DefaultConnection")));


                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<StudentDbContext>();
            });
        }
    }
}