using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Api2.Infrastructure.ApiServices
{
    /// <summary>
    /// Classe estática Genérica que prover o serviço de conexão com várias API's.
    /// </summary>
    /// <typeparam name="T"></typeparam>
  public static class ApiService<T>
  {
    private static HttpClient MountHeader(string uri)
    {
      HttpClient client = new HttpClient();

      client.BaseAddress = new Uri(uri);
      client.DefaultRequestHeaders.Add("User-Agent", "Api2");
      client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

      return client;
    }

    /// <summary>
    /// Método estático assincrono que faz requisição a Api's.
    /// </summary>
    /// <param name="uri">Representa a uri de uma api</param>
    /// <param name="servico">Representa o serviço que será consumido das Api's</param>
    /// <returns></returns>
    public static async Task<T> GetAsync(string uri, string servico)
    {
      T response;

      var client = MountHeader(uri);

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

      throw new Exception($"Não foi possível conectar com {uri}.");
    }

  }
}
