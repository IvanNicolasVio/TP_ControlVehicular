using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVehicularTest
{
    public class ValidadorTest
    {
        [Fact]
        public void ValidarKilometros_KilometrosValidos_RetornaValorConvertido()
        {
            // Arrange
            string km = "100";

            // Act
            int resultado = Validador.ValidarKilometros(km);

            // Assert
            Assert.Equal(100, resultado);
        }

        [Fact]
        public void ValidarKilometros_KilometrosIncorrectos_ArrojaExcepcion()
        {
            // Arrange
            string km = "abc";

            // Act & Assert
            Assert.Throws<ArgumentException>(() => Validador.ValidarKilometros(km));
        }

        [Fact]
        public void ValidarKilometros_KilometrosNegativos_ArrojaExcepcion()
        {
            // Arrange
            string km = "-10";

            // Act & Assert
            Assert.Throws<ArgumentException>(() => Validador.ValidarKilometros(km));
        }
    }
}
