using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Configuration;
using TrCrexDeneme.Core.Service;
using TrCrexDeneme.Model.Context;
using TrCrexDeneme.Model.Entities;
using TrCrexDeneme.Service.Base;
using TrCrexDeneme.Service.Options;
using TrCrexDeneme.Service.Tools;

namespace TrCrexDeneme.WebUII
{
    public class Startup
    {
       
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ProjectContext>(options => options.UseSqlServer("server=DESKTOP-3VCBFAJ;database=TrCrex;Trusted_Connection=True"));
            services.AddDependecyService();
            services.AddTransient<ICoreService<Currency>, CurrencyService>();
            services.AddControllersWithViews(); 
            services.AddMvc(x => x.EnableEndpointRouting = false);
            services.AddTransient<ICoreService<Currency>, CurrencyService>();
        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
            //app.UseHttpsRedirection();
            app.UseRouting();
            
             
            app.UseStaticFiles();
        }
    }
}
