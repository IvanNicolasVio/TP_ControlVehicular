using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmPrincipal.Clases
{
    internal class Vehiculo
    {
        private string _dominio;
        private string _tipo;
        private string _marca;
        private string _modelo;
        private int _kilometros;
        

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
            
        }

        public string MostrarDetalles() 
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Vehiculo: {Tipo}");
            sb.AppendLine($"Marca: {Marca}");
            sb.AppendLine($"Dominio: {Dominio}");

            return sb.ToString();
        }
    }
}
