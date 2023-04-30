using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmPrincipal.Clases
{
    internal class Persona
    {
        private string _nombre;
        private string _apellido;
        private int _dni;
        private int _edad;

        public Persona(string nombre, string apellido, int dni, int edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            Edad = edad;
        }

        public string Nombre 
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Apellido 
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public int DNI 
        {
            get { return _dni; }
            set { _dni = value; }
        }

        public int Edad 
        {
            get { return _edad; }
            set { _edad = value; }
        }

        public string Saludar() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Hola! Mi nombre es {Nombre} {Apellido} ");
            sb.AppendLine($"y tengo {Edad} años");
            return sb.ToString();
        }
    }

    //internal class chofer : persona 
    //{
        //private string _licencia;
        //private string _legajo;

       // public chofer(string licencia, string legajo)
        //{
//_licencia = licencia;
          //  _legajo = legajo;
       // }
   // }
}
