﻿using BibliotecaEntidades.AdministradoresDeClases;
using Clases;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BibliotecaEntidades.AdministradoresSQL
{
    public class AdmVehiculosSQL : ConexionSQL<Vehiculo>, IDato2<Vehiculo>
    {
        public AdmVehiculosSQL() : base()
        {
        }


        /// <summary>
        ///  Lee y retorna una lista de vehiculos de sql
        /// </summary>
        /// <returns></returns>
        public override List<Vehiculo> Leer()
        {
            try
            {
                var vehiculos = new List<Vehiculo>();
                Abrir();
                _command.CommandText = "SELECT * FROM Vehiculos";
                using (var dataReader = _command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        var dominio = dataReader["Dominio"].ToString() ?? "";
                        var tipo = dataReader["Tipo"].ToString() ?? "";
                        var marca = dataReader["Marca"].ToString() ?? "";
                        var modelo = dataReader["Modelo"].ToString() ?? "";
                        var kilometros = Convert.ToInt32(dataReader["Kilometros"]);
                        var id = Convert.ToInt32(dataReader["id"]);
                        var activo = Validador.ValidarAdministradorPorInt(Convert.ToInt32(dataReader["Activo"]));
                        var horarioSalida = dataReader["HorarioSalida"].ToString() ?? "";
                        var chofer = Validador.ConvertToInt(dataReader["PersonaAsignada"]);
                        vehiculos.Add(new Vehiculo(dominio, tipo, marca, modelo, kilometros, id,activo,horarioSalida,chofer));
                    }
                }
                return vehiculos;
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
        /// Agrega un vehiculo a una tabla en sql
        /// </summary>
        /// <param name="vehiculo"></param>
        public override void Agregar(Vehiculo vehiculo)
        {
            try
            {
                Abrir();
                _command.CommandText = $"INSERT INTO Vehiculos (Dominio,Tipo,Marca,Modelo,Kilometros,Activo) VALUES (@dominio,@tipo,@marca,@modelo,@kilometros,@activo)";
                _command.Parameters.AddWithValue("dominio", vehiculo.Dominio);
                _command.Parameters.AddWithValue("tipo", vehiculo.Tipo);
                _command.Parameters.AddWithValue("marca", vehiculo.Marca);
                _command.Parameters.AddWithValue("modelo", vehiculo.Modelo);
                _command.Parameters.AddWithValue("kilometros", vehiculo.Kilometros);
                _command.Parameters.AddWithValue("@activo", 0);
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
        /// Modifica un vehiculo en una tabla de vehiculos en sql
        /// </summary>
        /// <param name="vehiculo"></param>
        public override void ModificarLista(Vehiculo vehiculo)
        {
            using (var command = new SqlCommand())
            {
                try
                {
                    Abrir();
                    command.Connection = _connection; // Asigna la conexión existente al nuevo objeto de comando
                    command.CommandText = "UPDATE Vehiculos SET Dominio = @dominio, Tipo = @tipo, Marca = @marca, Modelo = @modelo, Kilometros = @kilometros WHERE Id = @id";
                    command.Parameters.AddWithValue("@dominio", vehiculo.Dominio);
                    command.Parameters.AddWithValue("@tipo", vehiculo.Tipo);
                    command.Parameters.AddWithValue("@marca", vehiculo.Marca);
                    command.Parameters.AddWithValue("@modelo", vehiculo.Modelo);
                    command.Parameters.AddWithValue("@kilometros", vehiculo.Kilometros);
                    command.Parameters.AddWithValue("@id", vehiculo.Id);
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
        /// Modifica un vehiculo de una tabla de vehiculos para cambiarle el valor de Activo,los kilometros, la persona asignada y el horario de salida
        /// </summary>
        /// <param name="vehiculo"></param>
        /// <param name="kilometros"></param>
        /// <param name="trueFalse"></param>
        /// <param name="personaAsignada"></param>
        /// <param name="horarioSalida"></param>
        public void Modificar(Vehiculo vehiculo, int kilometros, bool trueFalse, Persona personaAsignada, string horarioSalida)
        {
            try
            {
                Abrir();
                _command.CommandText = "UPDATE Vehiculos SET Kilometros = @kilometros,Activo = @activo,HorarioSalida = @horarioSalida WHERE Id = @id";
                _command.Parameters.AddWithValue("@kilometros", kilometros);
                _command.Parameters.AddWithValue("@activo", Validador.BoolAInt(trueFalse));
                _command.Parameters.AddWithValue("@horarioSalida", horarioSalida);
                _command.Parameters.AddWithValue("@id", vehiculo.Id);
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
        /// Modifica un vehiculo de una tabla de vehiculos para cambiarle el valor de Activo,los kilometros, la persona asignada y el horario de salida
        /// </summary>
        /// <param name="vehiculo"></param>
        /// <param name="trueFalse"></param>
        /// <param name="personaAsignada"></param>
        /// <param name="horarioSalida"></param>
        public void ModificarSinKm(Vehiculo vehiculo, bool trueFalse, Persona personaAsignada, string horarioSalida)
        {
            try
            {
                Abrir();
                _command.CommandText = "UPDATE Vehiculos SET Activo = @activo,PersonaAsignada = @personaAsiganada,HorarioSalida = @horarioSalida WHERE Id = @id";
                _command.Parameters.AddWithValue("@activo", Validador.BoolAInt(trueFalse));
                _command.Parameters.AddWithValue("@personaAsiganada", personaAsignada.Id);
                _command.Parameters.AddWithValue("@horarioSalida", horarioSalida);
                _command.Parameters.AddWithValue("@id", vehiculo.Id);
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
        /// Borra un vehiculo de una tabla de vehiculos en sql
        /// </summary>
        /// <param name="vehiculo"></param>
        public override void Borrar(Vehiculo vehiculo)
        {
            try
            {
                Abrir();
                _command.CommandText = $"DELETE FROM Vehiculos WHERE Id = @id";
                _command.Parameters.AddWithValue("id", vehiculo.Id);
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
