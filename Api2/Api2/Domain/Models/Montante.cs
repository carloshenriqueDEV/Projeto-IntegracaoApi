using Api2.Infrastructure.ApiServices;
using Api2.Infrastructure.ApiServices.Models.Api1;
using System;

namespace Api2.Domain.Models
{
    /// <summary>
    /// Classe que representa Montante de calculo de juros compostos.
    /// </summary>
    public class Montante
    {
        /// <summary>
        /// Retorna/Seta o valor inicial.
        /// </summary>
        public decimal ValorInicial { get; set; }
        /// <summary>
        /// Retorna/Seta a quantidade de meses.
        /// </summary>
        public int Meses { get; set; }
        /// <summary>
        /// Retorna/Seta o valor.
        /// </summary>
        public decimal Taxa { get; set; }
        /// <summary>
        /// Retorna/Seta o Resultado do calculo de montante.
        /// </summary>
        public decimal Resultado { get; set; }

        /// <summary>
        /// Construtor padrão.
        /// </summary>
        public Montante() { }

        /// <summary>
        /// Construtor que recebe o valor Inicial e a quantidade de meses.
        /// </summary>
        /// <param name="valorInicial"></param>
        /// <param name="meses"></param>
        public Montante(decimal valorInicial, int meses)
        {
            ValorInicial = valorInicial;
            Meses = meses;
            Taxa = ApiService<Taxa>.GetAsync(uri: "https://localhost:5001", servico:"/taxajuros").Result.Value;
            Resultado = CalculaMontante(valorInicial: valorInicial, taxa: Taxa, meses: meses);

        }       
       
        /// <summary>
        /// Método que calcula a potência passando base e expoente, o retorno é um tipo decimal.
        /// </summary>
        /// <param name="b">Representa a base</param>
        /// <param name="exp">Representa o expoente</param>
        /// <returns></returns>
        public decimal PowDecimal(decimal b, decimal exp)
        {
            var result = 1.0M;

            for (var i = 0; i < exp; ++i)
            {
                result *= b;
            }
            return result;
        }

        /// <summary>
        /// Método que recebe um valor decimal e o número de casas decimais,
        /// e retorna um decimal truncado com a quantidade de casa informadas.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="decimals"></param>
        /// <returns></returns>
        public decimal TruncateDecimal(decimal value, byte decimals)
        {
            decimal r = Math.Round(value, decimals);

            if (value > 0 && r > value)
            {
                return r - new decimal(1, 0, 0, false, decimals);
            }
            else if (value < 0 && r < value)
            {
                return r + new decimal(1, 0, 0, false, decimals);
            }

            return r;
        }

        /// <summary>
        /// Método que recebe Valor Inicial, Taxa e Meses, e retorna o montante calculado.
        /// </summary>
        /// <param name="valorInicial"></param>
        /// <param name="taxa"></param>
        /// <param name="meses"></param>
        /// <returns></returns>
        public decimal CalculaMontante(decimal valorInicial, decimal taxa, int meses)
        {
            var result = (valorInicial * PowDecimal((1.0M + taxa), meses));
            return TruncateDecimal(result, 2);

        }

    }
}
