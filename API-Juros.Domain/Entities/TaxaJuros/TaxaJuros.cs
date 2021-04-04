using System;

namespace APITaxaJuros.Domain.Entities.TaxaJuros
{
    public class TaxaJuros
    {
        public decimal Juros { get; private set; }

        public TaxaJuros()
        {

        }

        /// <summary>
        /// Atribui um valor decimal a propriedade "Juros" que representa a 1%
        /// </summary>
        public void GetTaxaJuros()
        {
            Juros = 0.01M;
        }
    }
}
