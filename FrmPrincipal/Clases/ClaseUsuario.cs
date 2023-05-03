using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmPrincipal.Clases
{
    internal class Usuario
    {
        private string _nombre;
        private string _contrasenia;
        private bool _administrador;

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
            private set {  _administrador = value; }
        }


        public Usuario(string nombre,string contrasenia,bool administrador) 
        {
            Nombre = nombre;
            Contrasenia = contrasenia;
            Administrador = administrador;
        }

        public bool validarAdministrador() 
        {
            if (Administrador) 
            {
                return true;
            }
            else { return false; }
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
