using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ManejadorVehiculosJson : ManejadorJson<Vehiculo>
    {
        public ManejadorVehiculosJson() : base("C:\\Users\\Iván\\source\\repos\\TP_ControlVehicular\\BibliotecaEntidades\\vehiculos.json")
        {

        }

        public void IngresarVehiculo(string dominio,string tipo,string marca,string modelo,string kilometros) 
        {
            var vehiculos = ObtenerDatos();
            int km = Validador.ValidarKilometros(kilometros);
           
            if (km > 0 && Validador.ValidarAnio(modelo) && Validador.ValidarPatente(dominio))
            {
                var vehiculo = new Vehiculo(dominio, tipo, marca, modelo, km);
                vehiculos.Add(vehiculo);
                Guardar(vehiculos);

            }
            else
            {
                throw new Exception("Datos erroneos");
            }
        }
    }
}
