using Clases;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ManejadorUsuarioJson : ManejadorJson<Usuario>
    {

        public static Usuario? UsuarioActivo { get; private set; }
        public ManejadorUsuarioJson() : base("C:\\Users\\Iván\\source\\repos\\TP_ControlVehicular\\BibliotecaEntidades\\usuarios.json")
        {

        }

        /// <summary>
        /// Hace el login de un usuario
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="contrasenia"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public Usuario Login(string nombre,string contrasenia) 
        {
            var usuarios = ObtenerDatos();

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
        public void MostrarLabels(string nombre,string tipoUsuario) 
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
            var usuarios = ObtenerDatos();
            Validador.ValidarUsuario(nombre);
            Validador.ValidarContrasenia(contrasenia);
            var adm = Validador.ValidarAdministrador(administrador);
            var usuario = new Usuario(nombre, contrasenia, adm);
            Validador.VerificarUsuarios(usuario, usuarios);
            usuarios.Add(usuario);
            Guardar(usuarios);
        }
    }
}
