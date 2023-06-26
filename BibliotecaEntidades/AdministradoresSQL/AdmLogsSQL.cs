using BibliotecaEntidades.Clases;
using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades.AdministradoresSQL
{
    public class AdmLogsSQL : ConexionSQL<Log>
    {
        public AdmLogsSQL() : base()
        {

        }

        /// <summary>
        /// Lee y devuelve una lista de LogParaPdf desde sql
        /// </summary>
        /// <returns></returns>
        public new List<LogParaPdf> Leer()
        {
            try
            {
                var logs = new List<LogParaPdf>();
                Abrir();
                _command.CommandText = "SELECT * FROM Logs";

                using (var dataReader = _command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        var usuario = dataReader["Usuario"].ToString() ?? "";
                        var Horario = dataReader["Horario"].ToString() ?? "";
                        var Metodo = dataReader["Metodo"].ToString() ?? "";
                        logs.Add(new LogParaPdf(usuario, Horario, Metodo));
                    }
                }
                return logs;
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
        /// Agrega un nombre,un horario y la descrpcion de un metodo a una tabla de logs
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="horario"></param>
        /// <param name="metodo"></param>
        public void Agregar(string usuario,string horario,string metodo)
        {
            try
            {
                Abrir();
                _command.CommandText = $"INSERT INTO Logs (Usuario,Horario,Metodo) VALUES (@usuario,@horario,@metodo)";
                _command.Parameters.AddWithValue("usuario", usuario);
                _command.Parameters.AddWithValue("horario", horario);
                _command.Parameters.AddWithValue("metodo", metodo);
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
