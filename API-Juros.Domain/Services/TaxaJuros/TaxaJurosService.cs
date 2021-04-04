using System;
using System.Threading.Tasks;
using APITaxaJuros.Domain.Interfaces.Services.TaxaJuros;

namespace APITaxaJuros.Domain.Service.TaxaJuros
{
    public class TaxaJurosService : ITaxaJurosService
    {
        public TaxaJurosService()
        {

        }

        /// <summary>
        /// Retorna um decimal sendo este o valor da propriedade "Juros" de forma assíncrona.
        /// </summary>
        /// <returns>decimal</returns>
        public async Task<decimal> GetTaxaJurosAsync()
        {
            var entidade = new Entities.TaxaJuros.TaxaJuros();

            entidade.GetTaxaJuros();

            return entidade.Juros;
        }
    }
}
