using POC_Consumindo_Api1.Refit.Models;
using Refit;
using System.Threading.Tasks;

namespace POC_Consumindo_Api1.Refit.Interfaces
{
    interface ITaxaApi1Sevice
    {
        [Get("/{servico}")]
        Task<TaxaResponse> GetTaxaAsync(string servico);
    }
}
