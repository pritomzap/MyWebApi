using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyWebApi.Models;
using MyWebApi.Services;

namespace MyWebApi
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            //services.AddMvc().SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0);

            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");

            var configuration = builder.Build();

            services.AddDbContext<InventoryContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));


            services.AddControllers();

            services.AddScoped<IInventoryServices, InventoryServices>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            /*if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseRouting();
            app.UseMvc(routes => { routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}"); });*/

            if (env.IsDevelopment())
            { 
                app.UseDeveloperExceptionPage();
            }
            app.UseHttpsRedirection(); 
            app.UseRouting(); 
           
            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}
