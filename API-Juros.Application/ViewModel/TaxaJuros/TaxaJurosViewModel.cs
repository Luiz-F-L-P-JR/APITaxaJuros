using System;
using System.Collections.Generic;
using System.Text;

namespace APITaxaJuros.Application.ViewModel.TaxaJuros
{
    public class TaxaJurosViewModel
    {
        public decimal Juros { get; set; }

        public TaxaJurosViewModel()
        {

        }

        public TaxaJurosViewModel(Domain.Entities.TaxaJuros.TaxaJuros entidade)
        {
            Juros = entidade.Juros;
        }
    }
}
