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


    }
}
