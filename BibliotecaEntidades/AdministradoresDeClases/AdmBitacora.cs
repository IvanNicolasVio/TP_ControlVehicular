using BibliotecaEntidades.AdministradoresSQL;
using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades.AdministradoresDeClases
{
    public static class AdmBitacora
    {
        /// <summary>
        /// Carga el vehiculo
        /// </summary>
        /// <param name="vehiculo"></param>
        /// <param name="horario"></param>
        /// <param name="km"></param>
        public static void CargarVehiculo(Vehiculo vehiculo, string horario, int km)
        {
            var admBitacora = new AdmBitacoraSQL();
            admBitacora.Agregar(vehiculo, horario, km);
        }

        /// <summary>
        /// Cuenta los viajes ya realizados
        /// </summary>
        /// <returns></returns>
        public static int ContarViajes() 
        {
            var admBitacora = new AdmBitacoraSQL();
            return admBitacora.ContarId();
        }

        /// <summary>
        /// Trae la lista de viajes
        /// </summary>
        /// <param name="viajes"></param>
        /// <returns></returns>
        public static List<ElementosDeBitacora> TraerLista(int viajes) 
        {
            var admBitacora = new AdmBitacoraSQL();
            return admBitacora.TraerElementos(viajes);
        }
    }
}
