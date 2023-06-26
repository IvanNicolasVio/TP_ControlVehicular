using BibliotecaEntidades.AdministradoresDeClases;
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
        private int? id_personaAsignada;
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

        public Vehiculo(string dominio, string tipo, string marca, string modelo, int kilometros,int id,bool activo,string horarioSalida,int? personaAsignada)
        {
            Dominio = dominio;
            Tipo = tipo;
            Marca = marca;
            Modelo = modelo;
            Kilometros = kilometros;
            Activo = activo;
            HorarioSalida = horarioSalida;
            PersonaAsignada = EncontrarChofer(personaAsignada);
            Id = id;
        }

        /// <summary>
        /// Encuentra un chofer por id en una lista de choferes
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Persona EncontrarChofer(int? id) 
        {
            if(id is int) 
            {
                var admChoferes = new AdmChoferes();
                return admChoferes.EncontrarChoferPorId(id);
            }
            else { return null; }
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

        public override string ToString()
        {
            var cadenaTexto = $"{Id},{Dominio},{Tipo},{Marca},{Modelo},{Kilometros}";
            return cadenaTexto;
        }
    }
}
