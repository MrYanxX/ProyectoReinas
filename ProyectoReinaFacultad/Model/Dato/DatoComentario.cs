using Model.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dato
{
    public class DatoComentario
    {
        private Conexion conexion = new Conexion();
        private SqlConnection sqlConnection;
        private SqlCommand command;

        public void M_RegistrarComentario(Comentario comentario)
        {
            try
            {
                // Abrir conexión a la base de datos
                sqlConnection = conexion.AbrirConexion();

                // Preparar el comando para ejecutar el procedimiento almacenado
                command = new SqlCommand("sp_InsertarComentario", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                // Agregar parámetros al comando
                command.Parameters.AddWithValue("@FotoId", comentario.FotoId);
                command.Parameters.AddWithValue("@UsuarioId", comentario.EstudianteId);
                command.Parameters.AddWithValue("@TextoComentario", comentario.TextoComentario);

                // Ejecutar el comando
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
                throw; // Re-lanzar la excepción para manejarla en el controlador
            }
            finally
            {
                command.Dispose();  // Liberar recursos 
                sqlConnection.Close();
            }
        }

    }
}
