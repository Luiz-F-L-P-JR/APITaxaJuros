using APITaxaJuros.Application;
using APITaxaJuros.Application.Interfaces.TaxaJuros;
using APITaxaJuros.Application.Services.TaxaJuros;
using APITaxaJuros.Domain.Interfaces.Services.TaxaJuros;
using APITaxaJuros.Domain.Service;
using APITaxaJuros.Domain.Service.TaxaJuros;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace APITaxaJuros.Infra.CrossCutting.IOC
{
    public static class IOC
    {
        public static void AddInjecaoDependencia(this IServiceCollection services)
        {
            services.AddTransient<ITaxaJurosAppService, TaxaJurosAppService>();
            services.AddTransient<ITaxaJurosService, TaxaJurosService>();
        }
    }
}
