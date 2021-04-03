using APITaxaJuros.Application.TaxaJuros;
using APITaxaJuros.Application.TaxaJuros.ViewModel;
using APITaxaJuros.Domain.TaxaJuros;
using System;
using System.Threading.Tasks;

namespace APITaxaJuros.Application
{
    public class TaxaJurosAppService : ITaxaJurosAppService
    {
        private readonly ITaxaJurosService _taxaJurosService;
        public TaxaJurosAppService(ITaxaJurosService taxaJurosService)
        {
            _taxaJurosService = taxaJurosService;
        }

        public async Task<TaxaJurosViewModel> GetTaxaJuros()
        {
            var retorno = await _taxaJurosService.GetTaxaJuros();

            return new TaxaJurosViewModel(retorno);
        }
    }
}
