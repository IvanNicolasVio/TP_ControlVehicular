using BibliotecaEntidades.AdministradoresSQL;
using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades.AdministradoresDeClases
{
    public class AdmVehiculos
    {
        private IDato2<Vehiculo> datos;
        public AdmVehiculos()
        {
            datos = new AdmVehiculosSQL();
        }

        public AdmVehiculos(IDato2<Vehiculo> datos)
        {
            this.datos = datos;
        }

        /// <summary>
        /// retorna una lista de vehiculos
        /// </summary>
        /// <returns></returns>
        public List<Vehiculo> TraerLista()
        {
            return datos.Leer();
        }

        /// <summary>
        /// borra un vehiculo de una lista de vehiculos
        /// </summary>
        /// <param name="vehiculo"></param>
        public void Borrar(Vehiculo vehiculo)
        {
            datos.Borrar(vehiculo);
        }

        /// <summary>
        /// Mdifica una lista de vehiculos
        /// </summary>
        /// <param name="lista"></param>
        public void EditarVehiculo(List<Vehiculo> lista)
        {
            foreach (Vehiculo vehiculo in lista)
            {
                datos.ModificarLista(vehiculo);
            }
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
        public void IngresarVehiculo(string dominio, string tipo, string marca, string modelo, string kilometros)
        {
            var vehiculos = TraerLista();
            var km = Validador.ValidarKilometros(kilometros);
            Validador.ValidarAnio(modelo);
            if (!Validador.ValidarPatente(dominio))
            {
                throw new Exception("Patente invalida");
            }
            var vehiculo = new Vehiculo(dominio, tipo, marca, modelo, km);
            Validador.VerificarVehiculo(vehiculo, vehiculos);
            datos.Agregar(vehiculo);
        }

        /// <summary>
        /// Cambia las propiedades de un objeto Vehiculo, lo hace activo, le asigna una persona y le agega un horario de salida
        /// </summary>
        /// <param name="dominio"></param>
        /// <param name="persona"></param>
        /// <param name="horario"></param>
        public void CargarSalidaVehiculo(string dominio, Persona persona, string horario)
        {
            if (persona is not Persona)
            {
                throw new Exception("Seleccione una persona");
            }
            var vehiculos = TraerLista();
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
                datos.ModificarSinKm(vehiculoSaliente, true, persona, horario);
            }


        }

        /// <summary>
        /// Cambia las propiedades de un objeto Vehiculo, le modifica los Kilometros, le cambia el activo a Falso, le quita la persona asignada y el horario de salida
        /// </summary>
        /// <param name="dominio"></param>
        /// <param name="km"></param>
        public void CargarEntradaVehiculo(string dominio, int km)
        {
            var vehiculos = TraerLista();
            Vehiculo vehiculoEntrante = null;
            foreach (var vehiculo in vehiculos)
            {
                if (dominio == vehiculo.Dominio)
                {
                    vehiculoEntrante = vehiculo;
                    vehiculos.Remove(vehiculo);
                    break;
                }


            }
            if (vehiculoEntrante is not null)
            {
                datos.Modificar(vehiculoEntrante, km, false, null, "");
            }


        }


        /// <summary>
        /// Busca el mismo objeto Vehiculo en una lista por la propiedad dominio
        /// </summary>
        /// <param name="dominio"></param>
        /// <returns></returns>
        public Vehiculo EncontrarVehiculo(string dominio)
        {
            var vehiculos = TraerLista();
            foreach (var vehiculo in vehiculos)
            {
                if (dominio == vehiculo.Dominio)
                {
                    return vehiculo;
                }
            }
            return null;

        }

        public void BorrarVehiculo(List<Vehiculo> vehiculos, Vehiculo selectedData) 
        {
            foreach (var vehiculo in vehiculos)
            {
                if (vehiculo == selectedData)
                {
                    this.Borrar(vehiculo);
                    break;
                }
            }
        }
    }
}
