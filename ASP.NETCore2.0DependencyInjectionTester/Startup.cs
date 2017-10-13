using System;
using DependencyInjectionTester.Interfaces;
using DependencyInjectionTester.Models;
using DependencyInjectionTester.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace DependencyInjectionTester
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                //options.UseInMemoryDatabase()
                options.UseSqlite("Data Source=DependencyInjectionTester.db")
            );                  //"Data Source=H:\\Kits\\Kit DotNET\\Dot NET\\ASP.NET\\Core\\ASP.NETCore2.0DependencyInjectionTester\\bin\\Debug\\netcoreapp2.0\\DependencyInjectionTester.db"

            // Add framework services.
            services.AddMvc();

            // Register application services.
            services.AddScoped<ICharacterRepository, CharacterRepository>();

            services.AddTransient<IOperationTransient, Operation>();
            services.AddScoped<IOperationScoped, Operation>();
            services.AddSingleton<IOperationSingleton, Operation>();
            services.AddSingleton<IOperationSingletonInstance>(new Operation("An singleton instance of Operation class ."));
            services.AddTransient<OperationService, OperationService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseMvcWithDefaultRoute();
        }
    }
}
