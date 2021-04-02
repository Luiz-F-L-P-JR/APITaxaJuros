using System;
using System.Threading.Tasks;

namespace API_Juros.Domain.Service
{
    public class TaxaJurosService : TaxaJuros.ITaxaJurosService
    {
        public TaxaJurosService()
        {

        }

        public async Task<TaxaJuros.TaxaJuros> GetTaxaJuros()
        {
            var entidade = new TaxaJuros.TaxaJuros();

            entidade.Juros = 0.01M;

            return await Task.FromResult(entidade);
        }
    }
}
