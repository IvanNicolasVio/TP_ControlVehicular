using Clases;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
    }
}
