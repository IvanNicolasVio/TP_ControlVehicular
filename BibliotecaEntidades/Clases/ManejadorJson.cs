
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Clases
{
    public class ManejadorJson<T>
    {
        string _path;


        public ManejadorJson(string path)
        {
            _path = path;
        }

        /// <summary>
        /// Hace un deserialize a un json y devuelve una lista de lista de T
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<T> ObtenerDatos() 
        {
            using var sr = new StreamReader(_path);
            string json = sr.ReadToEnd();
            var lista = JsonSerializer.Deserialize<List<T>>(json);
            if(lista is null) 
            {
                throw new Exception("No existe una lista");
            }
            return lista;
        }


        /// <summary>
        /// Hace un deserealize a un json y devuelve una lista de T
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public T ObtenerDato()
        {
            using var sr = new StreamReader(_path);
            string json = sr.ReadToEnd();
            var lista = JsonSerializer.Deserialize<T>(json);
            if (lista is null)
            {
                throw new Exception("No existe una lista");
            }
            return lista;
        }

        /// <summary>
        /// Guarda el dato pedido en un json
        /// </summary>
        /// <param name="dato"></param>
        public void Guardar(List<T> dato) 
        {
            string resultadoJson = JsonSerializer.Serialize<List<T>>(dato);
            File.WriteAllText(_path, resultadoJson);
        }
    }
}

    
