using BibliotecaEntidades.Clases;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class AdmUsuariosSQL : ConexionSQL<Usuario>, IDato<Usuario>
    {
        public AdmUsuariosSQL() : base()
        {
        }

        public override List<Usuario> Leer()
        {
            try
            {
                var usuarios = new List<Usuario>();
                Abrir();
                _command.CommandText = "SELECT * FROM Usuarios";
                
                using (var dataReader = _command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        var nombre = dataReader["Nombre"].ToString() ?? "";
                        var contrasenia = dataReader["Contrasenia"].ToString() ?? "";
                        var administrador = Validador.ValidarAdministradorPorInt(Convert.ToInt32(dataReader["Administrador"]));
                        var id = Convert.ToInt32(dataReader["id"]);
                        usuarios.Add(new Usuario(nombre, contrasenia, administrador, id));
                    }
                }
                return usuarios;
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

        public override void Agregar(Usuario usuario)
        {
            try
            {

                var admin = Validador.BoolAInt(usuario.Administrador);
                Abrir();
                _command.CommandText = $"INSERT INTO Usuarios (Nombre,Contrasenia,Administrador,Activo) VALUES (@nombre,@contrasenia,@admin,@activo)";
                _command.Parameters.AddWithValue("nombre", usuario.Nombre);
                _command.Parameters.AddWithValue("contrasenia", usuario.Contrasenia);
                _command.Parameters.AddWithValue("admin", admin);
                _command.Parameters.AddWithValue("activo", 0);
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

        public override void Borrar(Usuario usuario)
        {
            try
            {
                Abrir();
                _command.CommandText = $"DELETE FROM Usuarios WHERE Id = @id";
                _command.Parameters.AddWithValue("id", usuario.Id);
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

        public override void ModificarLista(Usuario usuario)
        {
            using (var command = new SqlCommand())
            {
                try
                {
                    var admin = Validador.BoolAInt(usuario.Administrador);
                    Abrir();
                    command.Connection = _connection; // Asigna la conexión existente al nuevo objeto de comando
                    command.CommandText = "UPDATE Vehiculos SET Nombre = @nombre, Contrasenia = @contrasenia, Administrador = @admin WHERE Id = @id";
                    _command.Parameters.AddWithValue("nombre", usuario.Nombre);
                    _command.Parameters.AddWithValue("contrasenia", usuario.Contrasenia);
                    _command.Parameters.AddWithValue("admin", admin);
                    command.Parameters.AddWithValue("@id", usuario.Id);
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

    }
}
