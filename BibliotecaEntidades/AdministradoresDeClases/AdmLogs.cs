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

        /// <summary>
        /// Hace Invoke al evento MetodoActivado
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="horario"></param>
        /// <param name="metodo"></param>
        public void MetodoActivadoON(string usuario, string horario, string metodo)
        {
            MetodoActivado?.Invoke(usuario, horario, metodo);
        }

        /// <summary>
        /// Ingresa los datos a una base de datos
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="horario"></param>
        /// <param name="metodo"></param>
        public void IngresarATabla(string usuario, string horario, string metodo)
        {
            var admLogsSQL = new AdmLogsSQL();
            admLogsSQL.Agregar(usuario, horario, metodo);
        }

        /// <summary>
        /// devuelve una lista de LogParaPdf de una base de datos
        /// </summary>
        /// <returns></returns>
        public List<LogParaPdf> DevolverLogs() 
        {
            var admLogsSQL = new AdmLogsSQL();
            return admLogsSQL.Leer();
        }
    }
}
