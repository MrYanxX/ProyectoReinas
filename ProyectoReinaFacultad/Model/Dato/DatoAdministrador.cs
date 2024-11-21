using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Modelo;

namespace Model.Dato
{
    public class DatoAdministrador
    {
        private Conexion conexion = new Conexion();
        SqlConnection sqlConnection = null;
        SqlCommand command = null;
        SqlDataReader dataReader;

        public void M_RegistrarAdministrador(Administrador administrador)
        {
            try
            {
                // Abrir conexión a la base de datos
                sqlConnection = conexion.AbrirConexion();

                // Preparar el comando para ejecutar el procedimiento almacenado
                command = new SqlCommand("sp_InsertarAdministrador", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                // Agregar parámetros al comando
                command.Parameters.AddWithValue("@Nombre", administrador.Nombre);
                command.Parameters.AddWithValue("@Apellido", administrador.Apellido);
                command.Parameters.AddWithValue("@Cedula", administrador.Cedula);
                command.Parameters.AddWithValue("@Contraseña", administrador.Contraseña);
                command.Parameters.AddWithValue("@Estado", administrador.Estado); // Agregar el estado

                // Ejecutar el comando
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }
            finally
            {
                command.Dispose();  // Liberar recursos 
                sqlConnection.Close();
            }
        }

        public List<Administrador> ConsultarAdministradores(string cedula, string estado)
        {
            List<Administrador> administradores = new List<Administrador>();

            try
            {
                sqlConnection = conexion.AbrirConexion();
                command = new SqlCommand("sp_ConsultarAdministradores", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Cedula", string.IsNullOrEmpty(cedula) ? (object)DBNull.Value : cedula);
                command.Parameters.AddWithValue("@Estado", string.IsNullOrEmpty(estado) ? (object)DBNull.Value : estado);

                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    administradores.Add(new Administrador
                    {
                        Id = Convert.ToInt32(dataReader["Id"]),
                        UsuarioId = Convert.ToInt32(dataReader["UsuarioId"]),
                        Nombre = dataReader["Nombre"].ToString(),
                        Apellido = dataReader["Apellido"].ToString(),
                        Cedula = dataReader["Cedula"].ToString(),
                        Contraseña = dataReader["Contraseña"].ToString(),
                        Estado = dataReader["Estado"].ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }
            finally
            {
                command.Dispose();
                sqlConnection.Close();
            }

            return administradores;
        }


        public void M_ActualizarAdministrador(Administrador administrador)
        {
            try
            {
                sqlConnection = conexion.AbrirConexion();
                command = new SqlCommand("sp_ActualizarAdministrador", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                // Agregar parámetros al comando
                command.Parameters.AddWithValue("@Id", administrador.Id);
                command.Parameters.AddWithValue("@Nombre", administrador.Nombre);
                command.Parameters.AddWithValue("@Apellido", administrador.Apellido);
                command.Parameters.AddWithValue("@Cedula", administrador.Cedula);
                command.Parameters.AddWithValue("@Contraseña", administrador.Contraseña);
                command.Parameters.AddWithValue("@Estado", administrador.Estado);

                // Ejecutar el comando
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }
            finally
            {
                command.Dispose();
                sqlConnection.Close();
            }
        }

        public void M_EliminarAdministrador(int id)
        {
            try
            {
                sqlConnection = conexion.AbrirConexion();
                command = new SqlCommand("sp_EliminarAdministrador", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Id", id);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }
            finally
            {
                command.Dispose();
                sqlConnection.Close();
            }
        }



    }
}
