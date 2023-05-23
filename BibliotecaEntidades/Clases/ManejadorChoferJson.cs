using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Clases
{
    public class ManejadorChoferJson : ManejadorJson<Persona>
    {
        public ManejadorChoferJson() : base("C:\\Users\\Iván\\source\\repos\\TP_ControlVehicular\\BibliotecaEntidades\\choferes.json")
        {

        }

        /// <summary>
        /// Crea un chofer y lo agrega a la lista de JSON
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="edad"></param>
        public void IngresarChofer(string nombre, string apellido, string dni, string edad)
        {
            var choferes = ObtenerDatos();
            Validador.ValidarNombreApellido(nombre);
            Validador.ValidarNombreApellido(apellido);
            var dniValido = Validador.ValidarDNI(dni);
            var edadValida = Validador.ValidarEdad(edad);
            var chofer = new Persona(nombre, apellido, dniValido, edadValida);
            Validador.VerificarChofer(chofer, choferes);
            choferes.Add(chofer);
            Guardar(choferes);

        }


        /// <summary>
        /// Encuentra un objeto Persona en una lista de personas por la propiedad DNI
        /// </summary>
        /// <param name="dni"></param>
        /// <returns></returns>
        public Persona EncontrarChofer(string dni)
        {
            var choferes = ObtenerDatos();
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
            var choferes = ObtenerDatos();
            foreach (var chofer in choferes)
            {
                if (persona == chofer)
                {
                    choferes.Remove(chofer);
                    persona.Activo = true;
                    choferes.Add(persona);
                    Guardar(choferes);
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
            var choferes = ObtenerDatos();
            foreach (var chofer in choferes)
            {
                if (persona == chofer)
                {
                    choferes.Remove(chofer);
                    persona.Activo = false;
                    choferes.Add(persona);
                    Guardar(choferes);
                    break;
                }
            }
        }
    }
}
