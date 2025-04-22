using System.Threading.Tasks;

namespace APITaxaJuros.Domain.Interfaces.Services.TaxaJuros
{
    public interface ITaxaJurosService
    {
        Task<decimal> GetTaxaJurosAsync();
    }
}
