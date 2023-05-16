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
            var km = Validador.ValidarKilometros(kilometros);
            Validador.ValidarAnio(modelo);
            if (!Validador.ValidarPatente(dominio))
            {
                throw new Exception("Patente invalida");
            }
            var vehiculo = new Vehiculo(dominio, tipo, marca, modelo, km);
            vehiculos.Add(vehiculo);
            Guardar(vehiculos);

        }
    }
}
