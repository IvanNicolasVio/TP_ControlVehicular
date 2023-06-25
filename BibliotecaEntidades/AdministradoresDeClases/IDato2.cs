using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades.AdministradoresDeClases
{
    public interface IDato2<T>
    {
        List<T> Leer();

        void Agregar(T dato);

        void ModificarBooleano(T dato, bool trueFalse);

        public void Modificar(Vehiculo vehiculo, int kilometros, bool trueFalse, Persona personaAsignada, string horarioSalida);

        public void ModificarSinKm(Vehiculo vehiculo, bool trueFalse, Persona personaAsignada, string horarioSalida);

        void Borrar(T dato);

        void ModificarLista(T dato);
    }
}
