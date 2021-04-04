using System;
using System.Threading.Tasks;

namespace APITaxaJuros.Domain.Service
{
    public class TaxaJurosService : TaxaJuros.ITaxaJurosService
    {
        public TaxaJurosService()
        {

        }

        public async Task<decimal> GetTaxaJurosAsync()
        {
            var entidade = new TaxaJuros.TaxaJuros();

            entidade.GetTaxaJuros();

            return entidade.Juros;
        }
    }
}
