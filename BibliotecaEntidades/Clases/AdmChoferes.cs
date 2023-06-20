﻿using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades.Clases
{
    public class AdmChoferes
    {
        private IDato<Persona> datos;

        public AdmChoferes()
        {
            datos = new AdmChoferesSQL();
        }
        public AdmChoferes(IDato<Persona> datos)
        {
            this.datos = datos;
        }

        public List<Persona> TraerLista()
        {
            return datos.Leer();
        }

        public void EditarChofer(List<Persona> lista)
        {
            foreach (Persona chofer in lista)
            {
                datos.ModificarLista(chofer);
            }
        }

        public void Borrar(Persona chofer) 
        {
            datos.Borrar(chofer);
        }

        /// <summary>
        /// Crea un chofer y lo agrega a la lista de SQL
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="edad"></param>
        public void IngresarChofer(string nombre, string apellido, string dni, string edad)
        {
            var choferes = TraerLista();
            Validador.ValidarNombreApellido(nombre);
            Validador.ValidarNombreApellido(apellido);
            var dniValido = Validador.ValidarDNI(dni);
            var edadValida = Validador.ValidarEdad(edad);
            var chofer = new Persona(nombre, apellido, dniValido, edadValida);
            Validador.VerificarChofer(chofer, choferes);
            datos.Agregar(chofer);
        }


        /// <summary>
        /// Encuentra un objeto Persona en una lista de personas por la propiedad DNI
        /// </summary>
        /// <param name="dni"></param>
        /// <returns></returns>
        public Persona EncontrarChofer(string dni)
        {
            var choferes = TraerLista();
            foreach (var chofer in choferes)
            {
                if (dni == chofer.DNI.ToString())
                {
                    return chofer;
                }
            }
            return null;
        }

        /// <summary>
        /// Hace que un objeto persona cambie su propiedad activo a True
        /// </summary>
        /// <param name="persona"></param>
        public void HacerActivoChofer(Persona persona)
        {
            var choferes = TraerLista();
            foreach (var chofer in choferes)
            {
                if (persona == chofer)
                {
                    datos.ModificarBooleano(persona, true);
                    break;
                }
            }
        }

        /// <summary>
        /// Hace que un objeto persona cambie su propiedad activo a False
        /// </summary>
        /// <param name="persona"></param>
        public void DesactivarChofer(Persona persona)
        {
            var choferes = TraerLista();
            foreach (var chofer in choferes)
            {
                if (persona == chofer)
                {
                    datos.ModificarBooleano(persona, false);
                    break;
                }
            }
        }
    }
}
