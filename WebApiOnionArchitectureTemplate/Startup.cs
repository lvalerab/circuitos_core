using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RepositoryLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.EntityFrameworkCore.Extensions;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Repository;
using DomainLayer.Models;
using RepositoryLayer.Contratos;

namespace WebApiOnionArchitectureTemplate
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title="Circuitos .NET Core", Version="v1" });
            });

            services.AddDbContext<ApplicationDbContext>(item => item.UseMySQL(Configuration.GetConnectionString("Desarrollo")));
            AddRepositoryDependency(services);
        }

        /// <summary>
        /// Añade las dependencias del repositorio
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        
        public void AddRepositoryDependency(IServiceCollection services)
        {
            services.AddScoped(typeof(ICrudRepository<UsuarioEntity, String>), typeof(Repository<UsuarioEntity, String>));
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebAPI Circuitos .Net core 0.0.1"));
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
           // app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

        }
    }
}
