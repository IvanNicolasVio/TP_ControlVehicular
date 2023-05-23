using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Bitacora
    {
        private string _rutaArchivo;

        public Bitacora() 
        {
            _rutaArchivo = "C:\\Users\\Iván\\source\\repos\\TP_ControlVehicular\\BibliotecaEntidades\\Bitacora.txt";
        }


        /// <summary>
        /// Crea y edita un archivo de texto con el texo pasado por parametro
        /// </summary>
        /// <param name="texto"></param>
        /// <exception cref="Exception"></exception>
        public void AgregarTexto(string texto)
        {
            using (StreamWriter escritor = File.AppendText(_rutaArchivo))
            {
                escritor.WriteLine(texto);
            }
            
            
        }
    }
    
}
