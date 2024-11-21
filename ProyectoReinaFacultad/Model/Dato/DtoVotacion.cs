using Model.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dato
{
    public class DtoVotacion
    {
        private Conexion conexion = new Conexion();
        SqlConnection sqlConnection = null;
        SqlCommand command = null;
        SqlDataReader dataReader;

        public void registrarVotacion(Votacion votacion)
        {

            try
            {
                // Abrir la conexión
                sqlConnection = conexion.AbrirConexion();

                // Configurar el comando
                command = new SqlCommand("sp_InsertarVotacion", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                // Agregar parámetros
                command.Parameters.AddWithValue("@CandidataId", votacion.CandidataId);
                command.Parameters.AddWithValue("@UsuarioId", votacion.EstudianteId);
                command.Parameters.AddWithValue("@TipoVoto", votacion.TipoVoto);

                // Ejecutar el comando
                command.ExecuteNonQuery();

                // Opcional: Aquí podrías registrar el éxito en un log si es necesario
            }
            catch (Exception ex)
            {
                // Manejar la excepción
                Console.WriteLine("ERROR: " + ex.Message);
                // Opcional: Considerar mostrar el error al usuario o registrar en un log
            }
            finally
            {
                // Liberar recursos
                if (command != null) command.Dispose();
                if (sqlConnection != null) sqlConnection.Close();
            }
        }

        public bool verificarVotacion(int usuarioId, string tipoVoto)
        {
            bool existeVotacion = false;
            SqlConnection sqlConnection = null;
            SqlCommand command = null;
            SqlDataReader reader = null;

            try
            {
                // Abrir la conexión
                sqlConnection = conexion.AbrirConexion();

                // Configurar el comando
                command = new SqlCommand("sp_VerificarVotacion", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                // Agregar parámetros
                command.Parameters.AddWithValue("@UsuarioId", usuarioId);
                command.Parameters.AddWithValue("@TipoVoto", tipoVoto);

                // Ejecutar el comando y leer el resultado
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int resultado = reader.GetInt32(0);
                    existeVotacion = resultado == 1;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }
            finally
            {
                // Liberar recursos
                if (reader != null) reader.Close();
                if (command != null) command.Dispose();
                if (sqlConnection != null) sqlConnection.Close();
            }

            return existeVotacion;
        }

    }
}