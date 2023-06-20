using BibliotecaEntidades.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class AdmChoferesSQL : ConexionSQL<Persona>, IDato<Persona>
    {
        public AdmChoferesSQL() : base()
        {
        }

        public override List<Persona> Leer()
        {
            try
            {
                var choferes = new List<Persona>();
                Abrir();
                _command.CommandText = "SELECT * FROM Choferes";
                using (var dataReader = _command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        var nombre = dataReader["Nombre"].ToString() ?? "";
                        var apellido = dataReader["Apellido"].ToString() ?? "";
                        var dni = Convert.ToInt32(dataReader["DNI"]);
                        var edad = Convert.ToInt32(dataReader["Edad"]);
                        var id = Convert.ToInt32(dataReader["id"]);
                        choferes.Add(new Persona(nombre, apellido, dni, edad, id));
                    }
                }
                return choferes;
            }
            catch
            {
                throw;
            }
            finally
            {
                Cerrar();
            }
        }

        public override void Agregar(Persona chofer) 
        {
            try
            {
                Abrir();
                _command.CommandText = $"INSERT INTO Choferes (Nombre,Apellido,DNI,Edad) VALUES (@nombre,@apellido,@dni,@edad)";
                _command.Parameters.AddWithValue("nombre", chofer.Nombre);
                _command.Parameters.AddWithValue("apellido", chofer.Apellido);
                _command.Parameters.AddWithValue("dni", chofer.DNI);
                _command.Parameters.AddWithValue("edad", chofer.Edad);
                _command.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                Cerrar();
            }
        }

        /// <summary>
        /// Sirve para ser iterada y modificar la lista
        /// </summary>
        /// <param name="vehiculo"></param>
        public override void ModificarLista(Persona chofer)
        {
            using (var command = new SqlCommand())
            {
                try
                {
                    Abrir();
                    command.Connection = _connection; // Asigna la conexión existente al nuevo objeto de comando
                    command.CommandText = "UPDATE Choferes SET Nombre = @nombre, Apellido = @apellido, DNI = @dni, Edad = @edad WHERE Id = @id";
                    command.Parameters.AddWithValue("nombre", chofer.Nombre);
                    command.Parameters.AddWithValue("apellido", chofer.Apellido);
                    command.Parameters.AddWithValue("dni", chofer.DNI);
                    command.Parameters.AddWithValue("edad", chofer.Edad);
                    command.Parameters.AddWithValue("@id", chofer.Id);
                    command.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
                finally
                {
                    Cerrar();
                }
            }
        }

        public override void ModificarBooleano(Persona chofer, bool trueFalse)
        {
            try
            {
                Abrir();
                _command.CommandText = "UPDATE Choferes SET Activo = @activo WHERE Id = @id";
                _command.Parameters.AddWithValue("@activo", Validador.BoolAInt(trueFalse));
                _command.Parameters.AddWithValue("@id", chofer.Id);
                _command.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                Cerrar();
            }
        }

        public override void Borrar(Persona chofer)
        {
            try
            {
                Abrir();
                _command.CommandText = $"DELETE FROM Choferes WHERE Id = @id";
                _command.Parameters.AddWithValue("id", chofer.Id);
                _command.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                Cerrar();
            }

        }
    }
}
