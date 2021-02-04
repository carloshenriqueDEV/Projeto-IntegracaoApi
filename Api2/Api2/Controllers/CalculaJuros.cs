using Api2.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api2.Controllers
{
    /// <summary>
    /// Classe que agrupa os endpoints que responde ao path relativo "/calculajuros?valorInicial={valor_decimal}&meses={valor_inteiro}".
    /// </summary>
    [Route("[controller]")]
    [ApiController]
    public class CalculaJuros : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="valorInicial"></param>
        /// <param name="meses"></param>
        /// <returns>Retorna o montante calculado, no tipo string.</returns>
        [HttpGet]
        public string Get(decimal valorInicial, int meses)

        {            
            return new Montante(valorInicial, meses).Resultado.ToString();
        }
    }
}
