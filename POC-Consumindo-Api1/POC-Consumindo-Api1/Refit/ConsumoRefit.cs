using POC_Consumindo_Api1.Refit.Interfaces;
using POC_Consumindo_Api1.Refit.Models;
using Refit;
using System.Threading.Tasks;

namespace POC_Consumindo_Api1.Refit
{
    class ConsumoRefit
    {
        public TaxaResponse Response { get; private set; }
        private ITaxaApi1Sevice ApiClient;

        public ConsumoRefit(string path, string servico)
        {
            ApiClient = RestService.For<ITaxaApi1Sevice>(path);
            Response = GetTaxaAsync(servico).Result; 
        }

        private async Task<TaxaResponse> GetTaxaAsync(string servico)
        {
             return await ApiClient.GetTaxaAsync(servico);
        }

    }
}
