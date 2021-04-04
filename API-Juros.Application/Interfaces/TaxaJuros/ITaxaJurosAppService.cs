using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace APITaxaJuros.Application.Interfaces.TaxaJuros
{
    public interface ITaxaJurosAppService
    {
        Task<decimal> GetTaxaJurosAsync();
    }
}
