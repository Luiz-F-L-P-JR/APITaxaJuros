using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace API_Juros.Domain.TaxaJuros
{
    public interface ITaxaJurosService
    {
        Task<TaxaJuros> GetTaxaJuros();
    }
}
