﻿using System;
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

        /// <summary>
        /// Valida si el usuario es administrador
        /// </summary>
        /// <returns></returns>
        public bool validarAdministrador()
        {
            if (Administrador)
            {
                return Administrador;
            }
            else { return false; }
        }

        public void editarUsuario(string nombre,string contrasenia,string adm) 
        {
            Validador.ValidarUsuario(nombre);
            Validador.ValidarContrasenia(contrasenia);
            var administrador = Validador.ValidarAdministrador(adm);
            this.Nombre = nombre;
            this.Contrasenia = contrasenia;
            this.Administrador = administrador;   
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
