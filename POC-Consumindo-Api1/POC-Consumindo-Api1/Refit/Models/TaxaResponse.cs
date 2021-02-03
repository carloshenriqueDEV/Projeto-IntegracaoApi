using Newtonsoft.Json;

namespace POC_Consumindo_Api1.Refit.Models
{
    class TaxaResponse
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }
}
