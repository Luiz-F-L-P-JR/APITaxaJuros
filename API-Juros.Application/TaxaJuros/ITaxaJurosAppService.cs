using API_Juros.Application.TaxaJuros.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace API_Juros.Application.TaxaJuros
{
    public interface ITaxaJurosAppService
    {
        Task<TaxaJurosViewModel> GetTaxaJuros();
    }
}
