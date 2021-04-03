using APITaxaJuros.Application;
using APITaxaJuros.Application.TaxaJuros;
using APITaxaJuros.Domain.Service;
using APITaxaJuros.Domain.TaxaJuros;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace APITaxaJuros.Infra.CrossCutting
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
