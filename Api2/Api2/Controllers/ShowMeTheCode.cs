using Api2.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api2.Controllers
{
   /// <summary>
   /// Classe que agrupa os endpoints que responde ao path relativo "/showmethecode".
   /// </summary>
  [Route("[controller]")]
  [ApiController]  
  public class ShowMeTheCode : ControllerBase
  {
        /// <summary>
        /// Get relativo a seguinte url https://localhost:5003/showmethecode .
        /// </summary>
        /// <returns>O nome do repositório : url github do projeto.</returns>
        [HttpGet]
    public string Get()
    {
      var repo = new Code();
      return $"{repo.Repositorio.Nome}: {repo.Repositorio.Url}";
    }
  }
}
