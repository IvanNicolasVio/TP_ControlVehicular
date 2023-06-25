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
        public static void CargarVehiculo(Vehiculo vehiculo, string horario, int km)
        {
            var admBitacora = new AdmBitacoraSQL();
            admBitacora.Agregar(vehiculo, horario, km);
        }

        public static int ContarViajes() 
        {
            var admBitacora = new AdmBitacoraSQL();
            return admBitacora.ContarId();
        }

        public static List<ElementosDeBitacora> TraerLista(int viajes) 
        {
            var admBitacora = new AdmBitacoraSQL();
            return admBitacora.TraerElementos(viajes);
        }
    }
}
