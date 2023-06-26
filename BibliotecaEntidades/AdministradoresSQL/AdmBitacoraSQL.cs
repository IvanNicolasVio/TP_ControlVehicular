using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEntidades.AdministradoresSQL
{
    public class AdmBitacoraSQL : ConexionSQL<Vehiculo>
    {
        public AdmBitacoraSQL() : base()
        {

        }

        /// <summary>
        /// Agrega un vehiculo, un horario y nuevos km a una lista de sqlserver llamada bitacora
        /// </summary>
        /// <param name="vehiculo"></param>
        /// <param name="horario"></param>
        /// <param name="km"></param>
        public void Agregar(Vehiculo vehiculo, string horario, int km)
        {
            try
            {
                Abrir();
                _command.CommandText = $"INSERT INTO Bitacora (Vehiculo,HorarioSalida,Chofer,DNI,HorarioLlegada,KilometrosAnteriores,KilometrosNuevos) VALUES (@vehiculo,@horarioSalida,@chofer,@dni,@horarioLlegada,@kmViejo,@kmNuevo)";
                _command.Parameters.AddWithValue("vehiculo", vehiculo.Dominio);
                _command.Parameters.AddWithValue("horarioSalida", vehiculo.HorarioSalida);
                _command.Parameters.AddWithValue("chofer", vehiculo.PersonaAsignada.Presentarse());
                _command.Parameters.AddWithValue("dni", vehiculo.PersonaAsignada.DNI);
                _command.Parameters.AddWithValue("horarioLlegada", horario);
                _command.Parameters.AddWithValue("@kmNuevo", km);
                _command.Parameters.AddWithValue("@kmViejo", vehiculo.Kilometros);
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
        /// Trae todos los id y los cuenta para devolver esa cantidad
        /// </summary>
        /// <returns></returns>
        public int ContarId()
        {
            var cantidadViajes = 0;
            try
            {
                Abrir();
                _command.CommandText = $"SELECT ID FROM Bitacora";
                using (var dataReader = _command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        cantidadViajes++;
                    }
                }
                return cantidadViajes;
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
        /// trae los elementos de una tabla de Elementos de bitacora y los devuelve en una lista
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public List<ElementosDeBitacora> TraerElementos(int numero) 
        {
            try
            {
                var elementos = new List<ElementosDeBitacora>();
                Abrir();
                _command.CommandText = $"SELECT TOP {numero} * FROM Bitacora ORDER BY ID DESC";
                using (var dataReader = _command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        var dominio = dataReader["Vehiculo"].ToString();
                        var hSalida = dataReader["HorarioSalida"].ToString();
                        var chofer = dataReader["Chofer"].ToString() ?? "";
                        var dni = Convert.ToInt32(dataReader["DNI"]);
                        var hLlegada = dataReader["HorarioLlegada"].ToString() ?? "";
                        var kmAnteriores = Convert.ToInt32(dataReader["KilometrosAnteriores"]);
                        var kmNuevos = Convert.ToInt32(dataReader["KilometrosNuevos"]);
                        elementos.Add(new ElementosDeBitacora(dominio, hSalida, chofer, dni, hLlegada, kmAnteriores, kmNuevos));
                    }
                }
                return elementos;
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
