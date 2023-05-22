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
        

        public string MostrarDetalles() 
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Vehiculo: {Tipo}");
            sb.AppendLine($"Marca: {Marca}");
            sb.AppendLine($"Dominio: {Dominio}");

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
