using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Vehiculo
    {
        private string _dominio;
        private string _tipo;
        private string _marca;
        private string _modelo;
        private int _kilometros;
        private bool _activo;
        private Persona _persona;
        private string _horarioSalida;
        private int _id;

        public int Id { get { return _id; } private set { _id = value; } }

        public bool Activo
        {
            get { return _activo; }
            set { _activo = value; }
        }

        public string HorarioSalida
        {
            get { return _horarioSalida; }
            set { _horarioSalida = value; }
        }

        public Persona PersonaAsignada
        {
            get { return _persona; }
            set { _persona = value; }
        }

        public string Dominio 
        {
            get { return _dominio; } set { _dominio = value;}
        }

        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        public string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }

        public string Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }

        public int Kilometros
        {
            get { return _kilometros; }
            set { _kilometros = value; }
        }

      
        public Vehiculo(string dominio, string tipo, string marca, string modelo, int kilometros)
        {
            Dominio = dominio;
            Tipo = tipo;
            Marca = marca;
            Modelo = modelo;
            Kilometros = kilometros;
            Activo = false;
            
        }

        public Vehiculo(string dominio, string tipo, string marca, string modelo, int kilometros,int id)
        {
            Dominio = dominio;
            Tipo = tipo;
            Marca = marca;
            Modelo = modelo;
            Kilometros = kilometros;
            Activo = false;
            Id = id;
        }


        /// <summary>
        /// Devuelve un string informando las distintas propiedades del objeto
        /// </summary>
        /// <param name="horario"></param>
        /// <returns></returns>
        public string MostrarDetallesDeSalida(string horario,int km) 
        {
            
            var sb = new StringBuilder();
            sb.AppendLine($"El vehiculo: {Dominio} ");
            sb.Append($" de tipo {Tipo}");
            sb.Append($" salio {HorarioSalida}");
            sb.Append($" con {PersonaAsignada.Nombre} {PersonaAsignada.Apellido}");
            sb.Append($" DNI: {PersonaAsignada.DNI}");
            sb.Append($" y volvio {horario}");
            sb.Append($" |||  Kilometros anteriores {Kilometros}");
            sb.Append($" |||  Kilometros actuales {km}");
            return sb.ToString();
        }

        public static bool operator ==(Vehiculo a, Vehiculo b)
        {
            if (a.Dominio == b.Dominio)
            {
                return true;
            }
            else { return false; }

        }

        public static bool operator !=(Vehiculo a, Vehiculo b)
        {
            if (a.Dominio != b.Dominio)
            {
                return false;
            }
            else { return true; }

        }
    }
}
