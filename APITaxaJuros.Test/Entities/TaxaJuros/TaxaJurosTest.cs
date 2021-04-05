using APITaxaJuros.Domain.Entities.TaxaJuros;
using System;
using Xunit;

namespace APITaxaJuros.Test
{
    public class TaxaJurosTest
    {
        [Theory]
        [InlineData(0.01)]
        public void TesteGetTaxaJuros(decimal resultado)
        {
            TaxaJuros taxaJuros = new TaxaJuros();

            taxaJuros.GetTaxaJuros();

            decimal juros = taxaJuros.Juros;

            Assert.Equal(juros, resultado);
        }
    }
}
