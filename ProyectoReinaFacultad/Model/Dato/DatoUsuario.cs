using Model.Modelo;
using System;
using System.Data.SqlClient;
using System.Data;

namespace Model.Dato
{
    public class DatoUsuario
    {
        private Conexion conexion = new Conexion();

        public Usuario ValidarUsuario(string cedula, string contraseña)
        {
            Usuario usuario = null;
            SqlConnection sqlConnection = null;

            try
            {
                sqlConnection = conexion.AbrirConexion();
                SqlCommand command = new SqlCommand("sp_ValidarUsuario", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Cedula", cedula);
                command.Parameters.AddWithValue("@Contraseña", contraseña);

                SqlDataReader dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    usuario = new Usuario
                    {
                        Id = Convert.ToInt32(dataReader["Id"]),
                        Cedula = dataReader["Cedula"].ToString(),
                        Contraseña = dataReader["Contraseña"].ToString(),
                        RolId = Convert.ToInt32(dataReader["RolId"]),
                        Estado = dataReader["Estado"].ToString()
                    };

                    // Verificar que la contraseña coincida exactamente, respetando mayúsculas y minúsculas
                    if (!usuario.Contraseña.Equals(contraseña))
                    {
                        usuario = null; // Invalidar el usuario si la contraseña no coincide exactamente
                    }
                }
                dataReader.Close();
                command.Dispose(); // Liberar recursos del comando
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);// Manejar la excepción de manera adecuada
                throw;
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return usuario;
        }
    }
}