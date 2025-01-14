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
    public class DatoEstudiante
    {
        private Conexion conexion = new Conexion();
        SqlConnection sqlConnection = null;
        SqlCommand command = null;
        SqlDataReader dataReader;

        public void M_RegistrarEstudiante(Estudiante estudiante)
        {
            try
            {
                // Abrir conexión a la base de datos
                sqlConnection = conexion.AbrirConexion();

                // Preparar el comando para ejecutar el procedimiento almacenado
                command = new SqlCommand("sp_InsertarEstudiante", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                // Agregar parámetros al comando
                command.Parameters.AddWithValue("@Matricula", estudiante.Matricula);
                command.Parameters.AddWithValue("@Nombre", estudiante.Nombre);
                command.Parameters.AddWithValue("@Apellido", estudiante.Apellido);
                command.Parameters.AddWithValue("@Cedula", estudiante.Cedula);
                command.Parameters.AddWithValue("@Contraseña", estudiante.Contraseña);
                command.Parameters.AddWithValue("@Estado", estudiante.Estado); // Agregar el estado

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

        public List<Estudiante> ConsultarEstudiantes(string cedula, string estado)
        {
            List<Estudiante> estudiantes = new List<Estudiante>();

            try
            {
                sqlConnection = conexion.AbrirConexion();
                command = new SqlCommand("sp_ConsultarEstudiantes", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Cedula", string.IsNullOrEmpty(cedula) ? (object)DBNull.Value : cedula);
                command.Parameters.AddWithValue("@Estado", string.IsNullOrEmpty(estado) ? (object)DBNull.Value : estado);

                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    estudiantes.Add(new Estudiante
                    {
                        Id = Convert.ToInt32(dataReader["Id"]),
                        UsuarioId = Convert.ToInt32(dataReader["UsuarioId"]),
                        Matricula = dataReader["Matricula"].ToString(),
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

            return estudiantes;
        }

        public void M_ActualizarEstudiante(Estudiante estudiante)
        {
            try
            {
                sqlConnection = conexion.AbrirConexion();
                command = new SqlCommand("sp_ActualizarEstudiante", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                // Agregar parámetros al comando
                command.Parameters.AddWithValue("@Id", estudiante.Id);
                command.Parameters.AddWithValue("@Matricula", estudiante.Matricula);
                command.Parameters.AddWithValue("@Nombre", estudiante.Nombre);
                command.Parameters.AddWithValue("@Apellido", estudiante.Apellido);
                command.Parameters.AddWithValue("@Cedula", estudiante.Cedula);
                command.Parameters.AddWithValue("@Contraseña", estudiante.Contraseña);
                command.Parameters.AddWithValue("@Estado", estudiante.Estado);

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


        public void M_EliminarEstudiante(int id)
        {
            try
            {
                sqlConnection = conexion.AbrirConexion();
                command = new SqlCommand("sp_EliminarEstudiante", sqlConnection);
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