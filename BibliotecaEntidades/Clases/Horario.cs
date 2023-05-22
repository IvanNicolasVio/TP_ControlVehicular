using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public static class Horario
    {
        /// <summary>
        /// Devuelve la fecha y hora actual.
        /// </summary>
        /// <returns></returns>
        public static string HorarioActual() 
        {
            DateTime momentoActual = DateTime.Now;
            string fechaHora = momentoActual.ToString("dd/MM/yyyy HH:mm");
            return fechaHora;
        }
    }
}
