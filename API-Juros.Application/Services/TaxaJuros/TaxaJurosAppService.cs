using APITaxaJuros.Application.Interfaces.TaxaJuros;
using APITaxaJuros.Application.ViewModel.TaxaJuros;
using APITaxaJuros.Domain.Interfaces.Services.TaxaJuros;
using System;
using System.Threading.Tasks;

namespace APITaxaJuros.Application.Services.TaxaJuros
{
    public class TaxaJurosAppService : ITaxaJurosAppService
    {
        private readonly ITaxaJurosService _taxaJurosService;
        public TaxaJurosAppService(ITaxaJurosService taxaJurosService)
        {
            _taxaJurosService = taxaJurosService;
        }

        /// <summary>
        /// Injeta o valor do "Juros".
        /// </summary>
        /// <returns>decimal</returns>
        public async Task<decimal> GetTaxaJurosAsync()
        {
            var retorno = await _taxaJurosService.GetTaxaJurosAsync().ConfigureAwait(false);

            if (retorno <= 0) return 0;

            return retorno;
        }
    }
}
