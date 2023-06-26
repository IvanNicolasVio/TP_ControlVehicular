using BibliotecaEntidades.AdministradoresDeClases;
using Clases;
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

namespace BibliotecaEntidades.AdministradoresSQL
{
    public class AdmChoferesSQL : ConexionSQL<Persona>, IDato<Persona>
    {
        public AdmChoferesSQL() : base()
        {
        }

        /// <summary>
        /// Lee y devuelve una lista de personas de sql
        /// </summary>
        /// <returns></returns>
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
                        var activo = Convert.ToInt32(dataReader["Activo"]);
                        var active = Validador.ValidarAdministradorPorInt(activo);
                        choferes.Add(new Persona(nombre, apellido, dni, edad, id, active));
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

        /// <summary>
        /// agrega una persona a una tabla de Choferes en sql
        /// </summary>
        /// <param name="chofer"></param>
        public override void Agregar(Persona chofer)
        {
            try
            {
                Abrir();
                _command.CommandText = $"INSERT INTO Choferes (Nombre,Apellido,DNI,Edad,Activo) VALUES (@nombre,@apellido,@dni,@edad,@activo)";
                _command.Parameters.AddWithValue("nombre", chofer.Nombre);
                _command.Parameters.AddWithValue("apellido", chofer.Apellido);
                _command.Parameters.AddWithValue("dni", chofer.DNI);
                _command.Parameters.AddWithValue("edad", chofer.Edad);
                _command.Parameters.AddWithValue("activo", Validador.BoolAInt(chofer.Activo));
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
        /// Itera una lista de choferes y los modifica
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

        /// <summary>
        /// Cambia el valor de la propiedad activo de una persona
        /// </summary>
        /// <param name="chofer"></param>
        /// <param name="trueFalse"></param>
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

        /// <summary>
        /// Borra una persona de la tabla choferes
        /// </summary>
        /// <param name="chofer"></param>
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
