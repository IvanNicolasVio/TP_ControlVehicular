using System;
using Clases;
using BibliotecaEntidades.AdministradoresSQL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades.AdministradoresDeClases
{
    public class AdmUsuarios
    {
        //private AdmUsuariosSQL datos;
        private IDato<Usuario> datos;
        public static Usuario? UsuarioActivo { get; private set; }

        public AdmUsuarios()
        {
            datos = new AdmUsuariosSQL();
        }

        public AdmUsuarios(IDato<Usuario> datos)
        {
            this.datos = datos;
        }

        public List<Usuario> TraerLista()
        {
            return datos.Leer();
        }

        public void Borrar(Usuario usuario)
        {
            datos.Borrar(usuario);
        }

        public void EditarChofer(List<Usuario> lista)
        {
            foreach (Usuario usuario in lista)
            {
                datos.ModificarLista(usuario);
            }
        }

        public Usuario Login(string nombre, string contrasenia)
        {
            var usuarios = datos.Leer();


            foreach (Usuario usuarioDeLista in usuarios)
            {
                if (nombre == usuarioDeLista.Nombre && contrasenia == usuarioDeLista.Contrasenia)
                {
                    UsuarioActivo = usuarioDeLista;
                    return usuarioDeLista;

                }

            }
            throw new Exception("Usuario no encontrado");
        }

        /// <summary>
        /// Crea unas labels segun un usuario activo
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="tipoUsuario"></param>
        public void MostrarLabels(string nombre, string tipoUsuario)
        {

            var usuario = UsuarioActivo;

            nombre = $"Usuario: {usuario!.Nombre}";

            if (usuario.validarAdministrador())
            {
                nombre = $"Tipo de usuario: Administrador";

            }
            else
            {
                tipoUsuario = $"Tipo de usuario: Comun";
            }
        }


        /// <summary>
        /// Crea un objeto Usuario y lo guarda en un JSON
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="contrasenia"></param>
        /// <param name="administrador"></param>
        public void CrearUsuario(string nombre, string contrasenia, string administrador)
        {
            var usuarios = TraerLista();
            Validador.ValidarUsuario(nombre);
            Validador.ValidarContrasenia(contrasenia);
            var adm = Validador.ValidarAdministrador(administrador);
            var usuario = new Usuario(nombre, contrasenia, adm);
            Validador.VerificarUsuarios(usuario, usuarios);
            datos.Agregar(usuario);
        }
    }
}
