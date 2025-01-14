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
    public class DatoAlbum
    {
        private Conexion conexion = new Conexion();
        SqlConnection sqlConnection = null;
        SqlCommand command = null;
        SqlDataReader dataReader;

        public void RegistrarFotos(List<Foto> fotos, int idCandidata)
        { 
            try
            {
                // Abrir conexión a la base de datos
                sqlConnection = conexion.AbrirConexion();

                // Preparar el comando para ejecutar el procedimiento almacenado
                command = new SqlCommand("sp_RegistrarAlbum", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                // Parámetros para el álbum
                command.Parameters.AddWithValue("@IdCandidata", idCandidata);

                // Parámetros para la primera foto
                command.Parameters.AddWithValue("@Imagen1", fotos[0].FotoData);
                command.Parameters.AddWithValue("@Titulo1", fotos[0].Titulo);
                command.Parameters.AddWithValue("@Descripcion1", fotos[0].Descripcion);

                // Parámetros para la segunda foto
                command.Parameters.AddWithValue("@Imagen2", fotos[1].FotoData);
                command.Parameters.AddWithValue("@Titulo2", fotos[1].Titulo);
                command.Parameters.AddWithValue("@Descripcion2", fotos[1].Descripcion);

                // Parámetros para la tercera foto
                command.Parameters.AddWithValue("@Imagen3", fotos[2].FotoData);
                command.Parameters.AddWithValue("@Titulo3", fotos[2].Titulo);
                command.Parameters.AddWithValue("@Descripcion3", fotos[2].Descripcion);

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

        public bool ConsultarAlbum(int id)
        {
            bool existe = false;

            try
            {
                sqlConnection = conexion.AbrirConexion();

                command = new SqlCommand("sp_ConsultarAlbum", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Id", id);
                
                // Agregar parámetro de salida
                SqlParameter parametroExiste = new SqlParameter("@Existe", SqlDbType.Bit)
                {
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(parametroExiste);

                // Ejecutar el comando
                command.ExecuteNonQuery();

                // Obtener el valor del parámetro de salida
                existe = (bool)parametroExiste.Value;
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

            return existe;
        }

        public List<Foto> consultarFotos(int idCandidata)
        {
            List<Foto> fotos = new List<Foto>();

            try
            {
                sqlConnection = conexion.AbrirConexion();
                command = new SqlCommand("sp_ConsultarFotosPorCandidata", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@IdCandidata", idCandidata);

                dataReader = command.ExecuteReader();
                {
                    while (dataReader.Read())
                    {
                        Foto foto = new Foto
                        {
                            Id = dataReader.GetInt32(dataReader.GetOrdinal("Id")),
                            AlbumId = dataReader.GetInt32(dataReader.GetOrdinal("AlbumId")),
                            Titulo = dataReader.GetString(dataReader.GetOrdinal("Titulo")),
                            Descripcion = dataReader.IsDBNull(dataReader.GetOrdinal("Descripcion")) ? null : dataReader.GetString(dataReader.GetOrdinal("Descripcion")),
                            FotoData = dataReader.IsDBNull(dataReader.GetOrdinal("Foto")) ? null : (byte[])dataReader["Foto"]
                        };
                        
                        fotos.Add(foto);
                    }
                }
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

            return fotos;
        }

        public bool actualizarAlbum(List<Foto> fotos)
        {
            if (fotos == null || fotos.Count != 3)
            {
                throw new ArgumentException("La lista debe contener exactamente tres fotos.");
            }

            SqlConnection sqlConnection = null;
            SqlCommand command = null;

            try
            {
                sqlConnection = conexion.AbrirConexion();
                command = new SqlCommand("sp_ActualizarFotos", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                // Agregar parámetros para la primera foto
                command.Parameters.AddWithValue("@IdFoto1", fotos[0].Id);
                command.Parameters.AddWithValue("@Titulo1", fotos[0].Titulo);
                command.Parameters.AddWithValue("@Descripcion1", fotos[0].Descripcion);
                command.Parameters.AddWithValue("@Foto1", fotos[0].FotoData);

                // Agregar parámetros para la segunda foto
                command.Parameters.AddWithValue("@IdFoto2", fotos[1].Id);
                command.Parameters.AddWithValue("@Titulo2", fotos[1].Titulo);
                command.Parameters.AddWithValue("@Descripcion2", fotos[1].Descripcion);
                command.Parameters.AddWithValue("@Foto2", fotos[1].FotoData);

                // Agregar parámetros para la tercera foto
                command.Parameters.AddWithValue("@IdFoto3", fotos[2].Id);
                command.Parameters.AddWithValue("@Titulo3", fotos[2].Titulo);
                command.Parameters.AddWithValue("@Descripcion3", fotos[2].Descripcion);
                command.Parameters.AddWithValue("@Foto3", fotos[2].FotoData);

                // Ejecutar el comando
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
                return false;
            }
            finally
            {
                command.Dispose();
                sqlConnection.Close();
            }
        }

    }
}

