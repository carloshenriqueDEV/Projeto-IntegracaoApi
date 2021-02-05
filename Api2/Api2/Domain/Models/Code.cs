using Api2.Infrastructure.ApiServices;
using Api2.Infrastructure.ApiServices.Models.GitHub;

namespace Api2.Domain.Models
{
    /// <summary>
    /// Classe que representa o código da aplicação.
    /// </summary>
    public class Code
    {
        /// <summary>
        /// Propriedade que retorna o repositório do github do projeto.
        /// </summary>
        public Repo Repositorio { get; private set; }

        /// <summary>
        /// Construtor padrão.
        /// </summary>
        public Code()
        {
            Repositorio = ApiService<Repo>.GetAsync(uri: "https://api.github.com", servico:"/repos/carloshenriqueDEV/Projeto-IntegracaoApi").Result;
        }
        
    }
}
