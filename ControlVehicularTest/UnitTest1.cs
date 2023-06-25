

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
            var usuario = admUsuarios.Login("UsuarioInvalido", "ContraseñaInvalida");

            // Assert
            Assert.Null(usuario);
            Assert.Equal("UsuarioInvalido", usuario.Nombre);
            Assert.Equal("ContraseñaInvalida", usuario.Contrasenia);
            Assert.False(usuario.Administrador);
        }

        [Fact]
        public void Login_UsuarioInexistente_RetornaNull()
        {
            // Arrange
            var datosFalsos = new DatosFalsos();
            var admUsuarios = new AdmUsuarios(datosFalsos);

            // Act
            var usuario = admUsuarios.Login("UsuarioInexistente", "Contraseña");

            // Assert
            Assert.Null(usuario);
            Assert.Equal("UsuarioInexistente", usuario.Nombre);
            Assert.Equal("Contraseña", usuario.Contrasenia);
            Assert.False(usuario.Administrador);
        }

        [Fact]
        public void Login_CredencialesIncorrectas_RetornaNull()
        {
            // Arrange
            var datosFalsos = new DatosFalsos();
            var admUsuarios = new AdmUsuarios(datosFalsos);

            // Act
            var usuario = admUsuarios.Login("Ivan", "ContraseñaIncorrecta");

            // Assert
            Assert.Null(usuario);
            Assert.Equal("Ivan", usuario.Nombre);
            Assert.Equal("ContraseñaIncorrecta", usuario.Contrasenia);
            Assert.False(usuario.Administrador);
        }
    }
}