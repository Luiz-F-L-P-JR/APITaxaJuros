using API_Juros.Application;
using API_Juros.Application.TaxaJuros;
using API_Juros.Domain.Service;
using API_Juros.Domain.TaxaJuros;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace API_Juros.Infra.CrossCutting
{
    public class IOC
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<ITaxaJurosAppService, TaxaJurosAppService>();
            services.AddTransient<ITaxaJurosService, TaxaJurosService>();
        }
    }
}
