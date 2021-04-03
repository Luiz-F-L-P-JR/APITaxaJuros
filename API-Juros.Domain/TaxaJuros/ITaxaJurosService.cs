using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace APITaxaJuros.Domain.TaxaJuros
{
    public interface ITaxaJurosService
    {
        Task<TaxaJuros> GetTaxaJuros();
    }
}
