using Api2.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api2.Controllers
{
    /// <summary>
    /// Classe que agrupa os endpoints que responde ao path relativo "/calculajuros?valorInicial={valor decimal}&meses={valor inteiro}".
    /// </summary>
    [Route("[controller]")]
    [ApiController]
    public class CalculaJuros : ControllerBase
    {
        /// <summary>
        /// Get relativo a seguinte url https://localhost:5003/calculajuros?valorInicial={valor decimal}&meses={valor inteiro} .
        /// </summary>
        /// <param name="valorInicial"></param>
        /// <param name="meses"></param>
        /// <returns></returns>
        [HttpGet]
        public JsonResult Get(decimal valorInicial, int meses)

        {            
            return new JsonResult(new Montante(valorInicial, meses).Resultado);
        }
    }
}
