using Api2.Domain.Models;
using Xunit;

namespace Api2.Testes
{
    public class MontanteTestes
    {
        [Fact]
        public void DadoValorInicialTaxaETempoRetornaMontate()
        {
            //Arranje
            Montante montante = new Montante();

            //Act
            var result = montante.CalculaMontante(100, 0.01M, 5);

            //Assert
            Assert.Equal<decimal>(105.10M, result);
        }

        [Fact]
        public void DadoBaseEExpoenteRetornaValorDaPotenciaCalculadaEmDecimal()
        {
            //Arranje
            Montante montante = new Montante();

            //Act
            var result = montante.PowDecimal(8, 2);

            //Assert
            Assert.Equal<decimal>(64.0M, result);
        }

        [Fact]
        public void DadoUmValorDoTipoDecimalEONuméroDeCasaDecimaisRetornaOValorEmDecimalTruncadoComAsQuantidadesDeCasasDeterminadas()
        {
            //Arranje
            Montante montante = new Montante();
            
            //Act
            var result = montante.TruncateDecimal(1.9021932M,4);

            //Assert
            Assert.Equal<decimal>(1.9021M, result);
        }
       
    }
}
