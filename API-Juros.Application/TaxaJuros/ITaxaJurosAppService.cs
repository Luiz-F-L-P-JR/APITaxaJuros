using APITaxaJuros.Application.TaxaJuros.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace APITaxaJuros.Application.TaxaJuros
{
    public interface ITaxaJurosAppService
    {
        Task<TaxaJurosViewModel> GetTaxaJuros();
    }
}
