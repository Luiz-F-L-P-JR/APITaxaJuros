using API_Juros.Application.TaxaJuros;
using API_Juros.Application.TaxaJuros.ViewModel;
using API_Juros.Domain.TaxaJuros;
using System;
using System.Threading.Tasks;

namespace API_Juros.Application
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
