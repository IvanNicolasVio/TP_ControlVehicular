using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public static class Validador
    {
        public static int ValidarKilometros(string km) 
        {
            bool esNumero = int.TryParse(km, out int numero);
            if (esNumero) 
            {
                return numero;
            }
            else { return -1; }
        }

        public static bool ValidarAnio(string anio) 
        {
            if(int.TryParse(anio, out var anioValidado))
            {
                int anioActual = DateTime.Now.Year;
                if (anioValidado > 1990 && anioValidado <= anioActual)
                {
                    return true;
                }
                else 
                { 
                    return false;
                }
            }
            else 
            {
                throw new ArgumentException("Año incorrecto");
            }
            
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
    }
}
