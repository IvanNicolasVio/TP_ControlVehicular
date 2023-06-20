using Clases;

namespace ControlVehicularTest
{
    public class AdmUsuariosTests
    {
        public class DatosFalsos : IDato<Usuario>
        {
            public void Agregar(Usuario dato)
            {
                throw new NotImplementedException();
            }

            public List<Usuario> Leer()
            {
                var listaUsuarios = new List<Usuario>();
                listaUsuarios.Add(new Usuario("Ivan", "45689", false));
                return listaUsuarios;
            }
        }


        [Fact]
        public void Login_LogearCorrectamente_ConUsuarioExistente()
        {

            //Arrange
            var datosFalsos = new DatosFalsos();
            var admUsuarios = new AdmUsuarios(datosFalsos);

            //Act
            var usuario = admUsuarios.Login("Ivan", "45689");
            

            //Assert
            Assert.NotNull(usuario);
            Assert.Equal("Ivan", usuario.Nombre);
            Assert.Equal("45689", usuario.Contrasenia);
            Assert.False(usuario.Administrador);
        }
    }
}