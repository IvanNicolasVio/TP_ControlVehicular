using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVehicularTest
{
    public class UnitTest3
    {
        [Fact]
        public void ValidarNumero_NumeroValido_RetornaValorConvertido()
        {
            // Arrange
            string numero = "100";

            // Act
            int resultado = Validador.ValidarNumero(numero);

            // Assert
            Assert.Equal(100, resultado);
        }

        [Fact]
        public void ValidarNumero_NumeroNoValido_ArrojaExcepcion()
        {
            // Arrange
            string numero = "abc";

            // Act & Assert
            Assert.Throws<ArgumentException>(() => Validador.ValidarNumero(numero));
        }

        [Fact]
        public void ValidarNumero_NumeroNegativo_ArrojaExcepcion()
        {
            // Arrange
            string numero = "-10";

            // Act & Assert
            Assert.Throws<ArgumentException>(() => Validador.ValidarNumero(numero));
        }
    }
}
