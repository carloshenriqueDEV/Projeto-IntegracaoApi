using Api1.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Api1.Controllers
{
  /// <summary>
  /// Classe que agrupa os endpoints que responde ao path relativo "/taxajuros" .
  /// </summary>
  [Route("[controller]")]
  [ApiController]
  public class TaxaJuros : Controller
  {
    public decimal _taxa {get; private set; }
    public TaxaJuros(IConfiguration config)
    {
        _taxa = config.GetValue<decimal>("TAXA");
    }
    /// <summary>
    /// 
    /// </summary>
    /// <returns>Retorna a taxa em formato json.</returns>
    [HttpGet]
    public JsonResult Get()
    {
      var taxa = new Taxa(_taxa);
      return new JsonResult(taxa);
    }
  }
}
