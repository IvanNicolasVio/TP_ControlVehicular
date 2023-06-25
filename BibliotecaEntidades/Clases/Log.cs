using BibliotecaEntidades.AdministradoresDeClases;
using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades.Clases
{
    public class Log
    {
        private readonly AdmLogs admLog;

        public Log() 
        {
            admLog = new AdmLogs();
            admLog.MetodoActivado += AdmLog_MetodoActivado;
        }

        public void AdmLog_MetodoActivado(string usuario, string horario, string metodo)
        {
            admLog.IngresarATabla(usuario, horario, metodo);
        }


    }
}
