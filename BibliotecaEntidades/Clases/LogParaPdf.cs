using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades.Clases
{
    public class LogParaPdf
    {
        private string _usuario;
        private string _horario;
        private string _metodo;

        public string Usuario { get { return _usuario; } set {  _usuario = value; } }
        public string Horario { get { return _horario; } set { _horario = value; } }
        public string Metodo { get { return _metodo; } set { _metodo = value; } }

        public LogParaPdf(string usuario,string horario,string metodo) 
        {
            Usuario = usuario;
            Horario = horario;
            Metodo = metodo;
        }
    }
}
