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


        /// <summary>
        /// Crea un Vehiculo y lo guarda en un JSON
        /// </summary>
        /// <param name="dominio"></param>
        /// <param name="tipo"></param>
        /// <param name="marca"></param>
        /// <param name="modelo"></param>
        /// <param name="kilometros"></param>
        /// <exception cref="Exception"></exception>
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
            Validador.VerificarVehiculo(vehiculo, vehiculos);
            vehiculos.Add(vehiculo);
            Guardar(vehiculos);

        }

        /// <summary>
        /// Cambia las propiedades de un objeto Vehiculo, lo hace activo, le asigna una persona y le agega un horario de salida
        /// </summary>
        /// <param name="dominio"></param>
        /// <param name="persona"></param>
        /// <param name="horario"></param>
        public void CargarSalidaVehiculo(string dominio, Persona persona, string horario)
        {
            if(persona is not Persona) 
            {
                throw new Exception("Seleccione una persona");
            }
            var vehiculos = ObtenerDatos();
            Vehiculo vehiculoSaliente = null;
            foreach (var vehiculo in vehiculos)
            {
                if (dominio == vehiculo.Dominio)
                {
                    vehiculoSaliente = vehiculo;
                    vehiculos.Remove(vehiculo);
                    break;
                }
            }
            if (vehiculoSaliente is not null) 
            {
                vehiculoSaliente.Activo = true;
                vehiculoSaliente.PersonaAsignada = persona;
                vehiculoSaliente.HorarioSalida = horario;
                vehiculos.Add(vehiculoSaliente);
                Guardar(vehiculos);
            }
            

        }

        /// <summary>
        /// Cambia las propiedades de un objeto Vehiculo, le modifica los Kilometros, le cambia el activo a Falso, le quita la persona asignada y el horario de salida
        /// </summary>
        /// <param name="dominio"></param>
        /// <param name="km"></param>
        public void CargarEntradaVehiculo(string dominio,int km)
        {
            var vehiculos = ObtenerDatos();
            Vehiculo vehiculoEntrante = null;
            foreach (var vehiculo in vehiculos)
            {
                if (dominio == vehiculo.Dominio)
                {
                    vehiculoEntrante = vehiculo;
                    vehiculos.Remove(vehiculo);
                    break ;
                }


            }
            if (vehiculoEntrante is not null)
            {
                vehiculoEntrante.Kilometros = km;
                vehiculoEntrante.Activo = false;
                vehiculoEntrante.PersonaAsignada = null;
                vehiculoEntrante.HorarioSalida = "";
                vehiculos.Add(vehiculoEntrante);
                Guardar(vehiculos);
            }


        }


        /// <summary>
        /// Busca el mismo objeto Vehiculo en una lista por la propiedad dominio
        /// </summary>
        /// <param name="dominio"></param>
        /// <returns></returns>
        public Vehiculo EncontrarVehiculo(string dominio)
        {
            var vehiculos = ObtenerDatos();
            foreach (var vehiculo in vehiculos)
            {
                if (dominio == vehiculo.Dominio)
                {
                    return vehiculo;
                }
                
                
            }
            return null;
            
        }
    }
}
