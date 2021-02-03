using Newtonsoft.Json;

namespace Api2.Infrastructure.ApiServices.Models.GitHub
{
    /// <summary>
    /// Classe que representa um repositório do domínio do github.
    /// </summary>
  public class Repo
  {
    /// <summary>
    /// Propriedade que retorna/seta o nome do repositório do github.
    /// </summary>
    [JsonProperty("name")]
    public string Nome { get; set; }
    /// <summary>
    /// Propriedade que retorna/seta a url do repositório do github.
    /// </summary>
    [JsonProperty("html_url")]
    public string Url { get; set; }
  }
}
