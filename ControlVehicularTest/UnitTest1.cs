

using BibliotecaEntidades.AdministradoresDeClases;
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

            void IDato<Usuario>.Borrar(Usuario dato)
            {
                throw new NotImplementedException();
            }

            void IDato<Usuario>.ModificarBooleano(Usuario dato, bool trueFalse)
            {
                throw new NotImplementedException();
            }

            void IDato<Usuario>.ModificarLista(Usuario dato)
            {
                throw new NotImplementedException();
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

        [Fact]
        public void Login_IngresarCredencialesInvalidas_RetornaNull()
        {
            // Arrange
            var datosFalsos = new DatosFalsos();
            var admUsuarios = new AdmUsuarios(datosFalsos);

            // Act
            var usuario = admUsuarios.Login("UsuarioInvalido", "Contrase�aInvalida");

            // Assert
            Assert.Null(usuario);
            Assert.Equal("UsuarioInvalido", usuario.Nombre);
            Assert.Equal("Contrase�aInvalida", usuario.Contrasenia);
            Assert.False(usuario.Administrador);
        }

        [Fact]
        public void Login_UsuarioInexistente_RetornaNull()
        {
            // Arrange
            var datosFalsos = new DatosFalsos();
            var admUsuarios = new AdmUsuarios(datosFalsos);

            // Act
            var usuario = admUsuarios.Login("UsuarioInexistente", "Contrase�a");

            // Assert
            Assert.Null(usuario);
            Assert.Equal("UsuarioInexistente", usuario.Nombre);
            Assert.Equal("Contrase�a", usuario.Contrasenia);
            Assert.False(usuario.Administrador);
        }

        [Fact]
        public void Login_CredencialesIncorrectas_RetornaNull()
        {
            // Arrange
            var datosFalsos = new DatosFalsos();
            var admUsuarios = new AdmUsuarios(datosFalsos);

            // Act
            var usuario = admUsuarios.Login("Ivan", "Contrase�aIncorrecta");

            // Assert
            Assert.Null(usuario);
            Assert.Equal("Ivan", usuario.Nombre);
            Assert.Equal("Contrase�aIncorrecta", usuario.Contrasenia);
            Assert.False(usuario.Administrador);
        }
    }
}