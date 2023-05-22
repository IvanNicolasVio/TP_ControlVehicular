using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public static class Validador
    {

        /// <summary>
        /// Valida que el año sea mayor a 1990 y menor o igual al actual
        /// </summary>
        /// <param name="anio"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static bool ValidarAnio(string anio) 
        {
            int anioValidado;
            int anioActual = DateTime.Now.Year;
            if (!int.TryParse(anio, out anioValidado)) 
            {
                throw new ArgumentException("Año incorrecto");
            }
            if (anioValidado < 1990) 
            {
                throw new ArgumentException("Año menor a 1990");
            }
            if(anioValidado > anioActual)
            {
                throw new ArgumentException("Año mayor al año actial");
            }
            return true;
        }

        /// <summary>
        /// Valida que las patentes sean Argentinas pj GYM536 /// AB515GK
        /// </summary>
        /// <param name="patente"></param>
        /// <returns></returns>
        public static bool ValidarPatente(string patente)
        {
            if (patente.Length == 6 || patente.Length == 7)
            {
                if (patente.Length == 6 && char.IsLetter(patente[0]) && char.IsLetter(patente[1])
                    && char.IsLetter(patente[2]) && char.IsDigit(patente[3]) && char.IsDigit(patente[4])
                    && char.IsDigit(patente[5]))
                {
                    return true;
                }
                else if (patente.Length == 7 && char.IsLetter(patente[0]) && char.IsLetter(patente[1])
                    && char.IsDigit(patente[2]) && char.IsDigit(patente[3]) && char.IsDigit(patente[4])
                    && char.IsLetter(patente[5]) && char.IsLetter(patente[6]))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Valida que los kilometros sean mayor a 0
        /// </summary>
        /// <param name="km"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static int ValidarKilometros(string km) 
        {
            if (!int.TryParse(km, out var kmValidado))
            {
                throw new ArgumentException("Kilometros incorrectos");
            }
            if(kmValidado < 0) 
            {
                throw new ArgumentException("Kilometros menores a 0");
            }

            return kmValidado;
        }


        /// <summary>
        /// valida que un string tenga mas de 2 caracteres y menos de 15
        /// </summary>
        /// <param name="nombre"></param>
        /// <exception cref="ArgumentException"></exception>
        public static void ValidarNombreApellido(string nombre) 
        {
            if(nombre.Length <= 2) 
            {
                throw new ArgumentException("El nombre debe tener mas de 2 caracteres");
            }
            if (nombre.Length > 15)
            {
                throw new ArgumentException("El nombre debe tener menos de 15 caracteres");
            }
        }


        /// <summary>
        ///  valida que sea un dni de 8 digitos
        /// </summary>
        /// <param name="dni"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static int ValidarDNI(string dni) 
        {
            if (dni.Length != 8)
            {
                throw new ArgumentException("El DNI debe tener 8 caracteres");
            }
            if (!int.TryParse(dni, out var dniValidado))
            {
                throw new ArgumentException("DNI incorrecto");
            }
            return dniValidado;
            
        }

        /// <summary>
        /// valida una edad mayor a 18 y menor a 60
        /// </summary>
        /// <param name="edad"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static int ValidarEdad(string edad) 
        {
            if (!int.TryParse(edad, out var edadValidadada))
            {
                throw new ArgumentException("Edad incorrecta");
            }
            if(edadValidadada < 17) 
            {
                throw new ArgumentException("La edad debe ser mayor a 18");
            }
            if (edadValidadada > 59)
            {
                throw new ArgumentException("La edad debe ser menor a 60");
            }

            return edadValidadada;
        }

        /// <summary>
        /// valida que un string tenga mas de 4 caracteres y menos de 8
        /// </summary>
        /// <param name="usuario"></param>
        /// <exception cref="ArgumentException"></exception>
        public static void ValidarUsuario(string usuario)
        {
            if (usuario.Length <= 4)
            {
                throw new ArgumentException("El usuario debe tener mas de 4 caracteres");
            }
            if (usuario.Length > 8)
            {
                throw new ArgumentException("El usuario debe tener menos de 8 caracteres");
            }
        }

        /// <summary>
        /// valida que un string tenga mas de 4 caracteres y menos de 6
        /// </summary>
        /// <param name="contrasenia"></param>
        /// <exception cref="ArgumentException"></exception>
        public static void ValidarContrasenia(string contrasenia)
        {
            if (contrasenia.Length <= 4)
            {
                throw new ArgumentException("La contrasenia debe tener mas de 4 caracteres");
            }
            if (contrasenia.Length > 6)
            {
                throw new ArgumentException("La contrasenia debe tener menos de 6 caracteres");
            }
        }


        /// <summary>
        /// Si es SI retorna true, si no false
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        public static bool ValidarAdministrador(string texto)
        {
            if (texto == "SI") 
            {
                return true;
            }
            else 
            {
                return false;
            }
            
        }

        /// <summary>
        /// Verifica si un usuario de una lista esta ya creado
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="listaDeUsuarios"></param>
        /// <exception cref="Exception"></exception>
        public static void VerificarUsuarios(Usuario usuario, List<Usuario> listaDeUsuarios) 
        {
            foreach (var user in listaDeUsuarios)
            {
                if(usuario == user) 
                {
                    throw new Exception("Usuario ya existente");
                }
                
            }
           
        }

        /// <summary>
        /// Valida que un chofer ya esta creado
        /// </summary>
        /// <param name="persona"></param>
        /// <param name="listaDeChoferes"></param>
        /// <exception cref="Exception"></exception>
        public static void VerificarChofer(Persona persona, List<Persona> listaDeChoferes)
        {
            foreach (var chofer in listaDeChoferes)
            {
                if (chofer != persona)
                {

                }
                throw new Exception("Chofer ya existente");
            }
        }

        /// <summary>
        /// Valida que un vehiculo ya este creado
        /// </summary>
        /// <param name="nuevoVehiculo"></param>
        /// <param name="listaDeVehiculos"></param>
        /// <exception cref="Exception"></exception>
        public static void VerificarVehiculo(Vehiculo nuevoVehiculo, List<Vehiculo> listaDeVehiculos)
        {
            foreach (var vehiculo in listaDeVehiculos)
            {
                if (vehiculo != nuevoVehiculo)
                {

                }
                throw new Exception("Vehiculo ya existente");
            }
        }
    }   
}
