using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public void IngresarChofer(string nombre, string apellido, string dni, string edad)
        {
            var choferes = ObtenerDatos();
            Validador.ValidarNombreApellido(nombre);
            Validador.ValidarNombreApellido(apellido);
            var dniValido = Validador.ValidarDNI(dni);
            var edadValida = Validador.ValidarEdad(edad);
            
            var chofer = new Persona(nombre, apellido, dniValido, edadValida);
            choferes.Add(chofer);
            Guardar(choferes);

        }
    }
}
