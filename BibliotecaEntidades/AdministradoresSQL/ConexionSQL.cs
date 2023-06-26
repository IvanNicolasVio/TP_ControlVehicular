using Clases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades.AdministradoresSQL
{
    public abstract class ConexionSQL<T>
    {
        protected SqlConnection _connection;
        protected SqlCommand _command;
        private string _connectionString;

        public ConexionSQL()
        {
            _command = new SqlCommand();
            _connectionString = @"Server=.;Database=ControlVehicular;Trusted_Connection=True;";
        }

        /// <summary>
        /// Abre una conexion sql
        /// </summary>
        public void Abrir()
        {
            _connection = new SqlConnection(_connectionString);
            _command.Connection = _connection;
            _connection.Open();

        }

        /// <summary>
        /// Cierra una conexion sql
        /// </summary>
        public void Cerrar()
        {
            _connection.Close();
        }

        public virtual List<T> Leer()
        {
            var lista = new List<T>();
            return lista;
        }

        public virtual void Agregar(T objeto)
        {

        }

        public virtual void ModificarLista(T objeto)
        {

        }

        public virtual void ModificarBooleano(T objeto, bool truefalse)
        {

        }

        public virtual void Borrar(T objeto)
        {

        }
    }
}
