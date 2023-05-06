
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Clases
{
    public class AdministradorJson<T>
    {
        string _path;


        public AdministradorJson(string path)
        {
            _path = path;
        }

        public T ObtenerDatos() 
        {
            using var sr = new StreamReader(_path);
            string json = sr.ReadToEnd();
            var lista = JsonSerializer.Deserialize<T>(json);
            return lista;
        }

        public void Guardar(T dato) 
        {
            string resultadoJson = JsonSerializer.Serialize<T>(dato);
            File.WriteAllText(_path, resultadoJson);
        }
    }
}

    
