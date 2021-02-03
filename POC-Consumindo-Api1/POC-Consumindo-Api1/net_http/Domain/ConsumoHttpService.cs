using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace POC_Consumindo_Api1.net_http.Domain
{
    class ConsumoHttpService<T>
    {
        private HttpClient client;

        public ConsumoHttpService(HttpClient httpClient,string uri)
        {
            client = httpClient;

            client.BaseAddress = new Uri(uri);

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<T> GetAsync(string servico)
        {
            T response;

            try
            {
                HttpResponseMessage res = await client.GetAsync(servico);

                if (res.IsSuccessStatusCode)
                {
                    var dados = await res.Content.ReadAsStringAsync();
                    response = JsonConvert.DeserializeObject<T>(dados);
                    return response;
                }
               
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return JsonConvert.DeserializeObject<T>(null);
        }
    }
}

