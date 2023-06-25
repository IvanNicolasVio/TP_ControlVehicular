using BibliotecaEntidades.AdministradoresSQL;
using BibliotecaEntidades.Clases;
using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BibliotecaEntidades.AdministradoresDeClases
{
    public class AdmLogs
    {
        public delegate void HandlerActivacionMetodo(string usuario, string horario, string metodo);
        public event HandlerActivacionMetodo MetodoActivado;
        public AdmLogs()
        {

        }

        public void MetodoActivadoON(string usuario, string horario, string metodo)
        {
            MetodoActivado?.Invoke(usuario, horario, metodo);
        }

        public void IngresarATabla(string usuario, string horario, string metodo)
        {
            var admLogsSQL = new AdmLogsSQL();
            admLogsSQL.Agregar(usuario, horario, metodo);
        }

        public List<LogParaPdf> DevolverLogs() 
        {
            var admLogsSQL = new AdmLogsSQL();
            return admLogsSQL.Leer();
        }
    }
}
