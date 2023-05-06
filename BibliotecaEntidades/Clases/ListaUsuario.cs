using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ListaUsuario
    {
        private List<Usuario> _usuarios;

        public ListaUsuario()
        {
            _usuarios = new List<Usuario>();
        }

        public void AgregarUsuario(Usuario usuario)
        {
            _usuarios.Add(usuario);
        }

        public void EliminarUsuario(Usuario usuario) 
        {
            _usuarios.Remove(usuario);
        }

        public Usuario BuscarUsuario(Usuario usuario,string nombre) 
        {
            return _usuarios.Find(usu => usuario.Nombre == nombre);
        }

        
    }

    
}
