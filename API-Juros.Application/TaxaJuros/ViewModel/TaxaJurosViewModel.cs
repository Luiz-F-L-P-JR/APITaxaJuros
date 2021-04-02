﻿using System;
using System.Collections.Generic;
using System.Text;

namespace API_Juros.Application.TaxaJuros.ViewModel
{
    public class TaxaJurosViewModel
    {
        public decimal Juros { get; set; }

        public TaxaJurosViewModel()
        {

        }

        public TaxaJurosViewModel(Domain.TaxaJuros.TaxaJuros entidade)
        {
            Juros = entidade.Juros;
        }
    }
}