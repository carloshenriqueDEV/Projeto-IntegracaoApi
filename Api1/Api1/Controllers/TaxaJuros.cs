﻿using Api1.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api1.Controllers
{
    /// <summary>
    /// Classe que agrupa os endpoints que responde ao path relativo "/taxajuros" .
    /// </summary>
    [Route("[controller]")]
    [ApiController]
    public class TaxaJuros : Controller
    {
        /// <summary>
        /// Get relativo a seguinte url https://localhost:5001/taxajuros.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public JsonResult Get()
        {
            var taxa = new Taxa(0.01M);
            return new JsonResult(taxa);
        }
    }
}