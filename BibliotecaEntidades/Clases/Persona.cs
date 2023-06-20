using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Persona
    {
        private string _nombre;
        private string _apellido;
        private int _dni;
        private int _edad;
        private bool _activo;
        private int _id;
        

        public Persona(string nombre, string apellido, int dni, int edad,int id)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            Edad = edad;
            Activo = false;
            Id = id;
        }

        public Persona(string nombre, string apellido, int dni, int edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            Edad = edad;
            Activo = false;
          
        }

        public int Id { get { return _id; } private set { _id = value; } }
        public bool Activo
        {
            get { return _activo; }
            set { _activo = value; }
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

        /// <summary>
        /// Devuelve un string con el nombre y el apellido
        /// </summary>
        /// <returns></returns>
        public string Presentarse() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Nombre} {Apellido} ");
            return sb.ToString();
        }

        public static bool operator ==(Persona a, Persona b)
        {
            if (a.DNI == b.DNI)
            {
                return true;
            }
            else { return false; }

        }

        public static bool operator !=(Persona a, Persona b)
        {
            if (a.DNI != b.DNI)
            {
                return false;
            }
            else { return true; }

        }

        public override string ToString()
        {
            var cadenaTexto = $"{Nombre} {Apellido}";
            return cadenaTexto;
        }

    }

    
}
