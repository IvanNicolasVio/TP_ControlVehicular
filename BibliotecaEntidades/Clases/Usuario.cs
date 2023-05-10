using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Usuario
    {
        private string _nombre;
        private string _contrasenia;
        private bool _administrador;
        private bool _activo;

        public string Nombre
        {
            get { return _nombre; }
            private set { _nombre = value; }
        }

        public string Contrasenia
        {
            get { return _contrasenia; }
            private set { _contrasenia = value; }
        }

        public bool Administrador
        {
            get { return _administrador; }
            private set { _administrador = value; }
        }

        public bool Activo
        {
            get { return _activo; }
            private set { _activo = value; }
        }

        public Usuario(string nombre, string contrasenia, bool administrador)
        {
            Nombre = nombre;
            Contrasenia = contrasenia;
            Administrador = administrador;
            Activo = false;
        }

        public bool validarAdministrador()
        {
            if (Administrador)
            {
                return true;
            }
            else { return false; }
        }

        public bool validarUsuarioActivo()
        {
            if (Activo) { return true; } else { return false; }
        }

        public void cambiarActivo() 
        {
            if (Activo) { Activo = false; }else if(!Activo) { Activo = true; }
        }

        private void editarUsuario(Usuario usuario,string nombre,string contrasenia,bool administrador) 
        {
            usuario.Nombre = nombre;
            usuario.Contrasenia = contrasenia;
            usuario.Administrador = administrador;
        }

        public static bool operator ==(Usuario a, Usuario b) 
        {
            if(a.Nombre == b.Nombre) 
            {
                return true;
            }
            else { return false; }

        }

        public static bool operator !=(Usuario a,Usuario b) 
        {
            if(a.Nombre != b.Nombre) 
            {
                return false;
            }
            else { return true; }

        }
    }
}
