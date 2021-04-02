using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Juros.Application;
using API_Juros.Application.TaxaJuros;
using API_Juros.Domain.Service;
using API_Juros.Domain.TaxaJuros;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace API_Juros
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
            services.AddTransient<ITaxaJurosAppService, TaxaJurosAppService>();
            services.AddTransient<ITaxaJurosService, TaxaJurosService>();
            
            services.AddControllers();


            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "Taxa de Juros",
                        Version = "v1",
                        Description = "API criada com o objetivo de devolver um registo numerico que representa uma porcentagem.",
                        Contact = new OpenApiContact
                        {
                            Name = "Luiz Fernando",
                            Email = "luizfernandojr1998@gmail.com"
                        }
                    });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();

            app.UseSwaggerUI(c => 
            {
                c.RoutePrefix = "Swagger";
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "TaxaJuros API");
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
