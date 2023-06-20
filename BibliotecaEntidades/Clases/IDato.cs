using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Clases
{
    public interface IDato<T>
    {
        List<T> Leer();

        void Agregar(T dato);

        void ModificarBooleano(T dato, bool trueFalse);

        void Borrar(T dato);

        void ModificarLista(T dato);
    }
}
