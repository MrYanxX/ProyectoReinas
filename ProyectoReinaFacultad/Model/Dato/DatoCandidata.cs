using Model.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace Model.Dato
{
    public class DatoCandidata
    {
        private Conexion conexion = new Conexion();
        SqlConnection sqlConnection = null;
        SqlCommand command = null;
        SqlDataReader dataReader;

        public void M_RegistrarCandidata(Candidata candidata)
        {
            try
            {
                sqlConnection = conexion.AbrirConexion();
                command = new SqlCommand("sp_InsertarCandidata", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Cedula", candidata.Cedula);
                command.Parameters.AddWithValue("@Nombre", candidata.Nombre);
                command.Parameters.AddWithValue("@Apellido", candidata.Apellido);
                command.Parameters.AddWithValue("@Edad", candidata.Edad);
                command.Parameters.AddWithValue("@Correo", candidata.Correo);
                command.Parameters.AddWithValue("@Celular", candidata.Celular);
                command.Parameters.AddWithValue("@Carrera", candidata.Carrera);
                command.Parameters.AddWithValue("@Nivel", candidata.Nivel);
                command.Parameters.AddWithValue("@Pasatiempos", candidata.Pasatiempos);
                command.Parameters.AddWithValue("@Habilidades", candidata.Habilidades);
                command.Parameters.AddWithValue("@Intereses", candidata.Intereses);
                command.Parameters.AddWithValue("@Aspiraciones", candidata.Aspiraciones);
                command.Parameters.AddWithValue("@Foto", candidata.Foto);
                command.Parameters.AddWithValue("@Estado", candidata.Estado);

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

        public List<Candidata> ConsultarCandidatas(string cedula, string estado)
        {
            List<Candidata> candidatas = new List<Candidata>();

            try
            {
                sqlConnection = conexion.AbrirConexion();
                command = new SqlCommand("sp_ConsultarCandidatas", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Cedula", string.IsNullOrEmpty(cedula) ? (object)DBNull.Value : cedula);
                command.Parameters.AddWithValue("@Estado", string.IsNullOrEmpty(estado) ? (object)DBNull.Value : estado);

                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    candidatas.Add(new Candidata
                    {
                        Id = Convert.ToInt32(dataReader["Id"]),
                        Cedula = dataReader["Cedula"].ToString(),
                        Nombre = dataReader["Nombre"].ToString(),
                        Apellido = dataReader["Apellido"].ToString(),
                        Edad = dataReader["Edad"].ToString(),
                        Correo = dataReader["Correo"].ToString(),
                        Celular = dataReader["Celular"].ToString(),
                        Carrera = dataReader["Carrera"].ToString(),
                        Nivel = dataReader["Nivel"].ToString(),
                        Pasatiempos = dataReader["Pasatiempos"].ToString(),
                        Habilidades = dataReader["Habilidades"].ToString(),
                        Intereses = dataReader["Intereses"].ToString(),
                        Aspiraciones = dataReader["Aspiraciones"].ToString(),
                        Foto = dataReader["Foto"] as byte[],
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
            return candidatas;
        }

        public List<Candidata> ConsultarCandidatasPorNombre(string nombre)
        {
            List<Candidata> candidatas = new List<Candidata>();

            try
            {
                // Abrir la conexión a la base de datos
                sqlConnection = conexion.AbrirConexion();

                // Preparar el comando para ejecutar el procedimiento almacenado
                command = new SqlCommand("sp_ConsultarCandidatasPorNombre", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                // Agregar el parámetro de nombre al comando
                if (string.IsNullOrEmpty(nombre))
                {
                    command.Parameters.AddWithValue("@Nombre", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@Nombre", nombre);
                }

                // Ejecutar el procedimiento almacenado y obtener un lector de datos
                dataReader = command.ExecuteReader();

                // Leer los resultados y agregar cada candidata a la lista
                while (dataReader.Read())
                {
                    candidatas.Add(new Candidata
                    {
                        Id = Convert.ToInt32(dataReader["Id"]),
                        Cedula = dataReader["Cedula"].ToString(),
                        Nombre = dataReader["Nombre"].ToString(),
                        Apellido = dataReader["Apellido"].ToString(),
                        Edad = dataReader["Edad"].ToString(),
                        Correo = dataReader["Correo"].ToString(),
                        Celular = dataReader["Celular"].ToString(),
                        Carrera = dataReader["Carrera"].ToString(),
                        Nivel = dataReader["Nivel"].ToString(),
                        Pasatiempos = dataReader["Pasatiempos"].ToString(),
                        Habilidades = dataReader["Habilidades"].ToString(),
                        Intereses = dataReader["Intereses"].ToString(),
                        Aspiraciones = dataReader["Aspiraciones"].ToString(),
                        Foto = dataReader["Foto"] as byte[],
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
                // Liberar recursos
                command.Dispose();
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }

            return candidatas;
        }

        public Candidata ConsultarCandidataPorId(int id)
        {
            Candidata candidata = null; // Inicializar como null para representar que no se encontró ninguna candidata

            try
            {
                // Abrir la conexión a la base de datos
                sqlConnection = conexion.AbrirConexion();

                // Preparar el comando para ejecutar el procedimiento almacenado
                command = new SqlCommand("sp_ConsultarCandidatasPorId", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                // Agregar el parámetro de id al comando
                command.Parameters.AddWithValue("@Id", id);

                // Ejecutar el procedimiento almacenado y obtener un lector de datos
                dataReader = command.ExecuteReader();

                // Leer el resultado y asignar la candidata encontrada
                if (dataReader.Read())
                {
                    candidata = new Candidata
                    {
                        Id = Convert.ToInt32(dataReader["Id"]),
                        Cedula = dataReader["Cedula"].ToString(),
                        Nombre = dataReader["Nombre"].ToString(),
                        Apellido = dataReader["Apellido"].ToString(),
                        Edad = dataReader["Edad"].ToString(),
                        Correo = dataReader["Correo"].ToString(),
                        Celular = dataReader["Celular"].ToString(),
                        Carrera = dataReader["Carrera"].ToString(),
                        Nivel = dataReader["Nivel"].ToString(),
                        Pasatiempos = dataReader["Pasatiempos"].ToString(),
                        Habilidades = dataReader["Habilidades"].ToString(),
                        Intereses = dataReader["Intereses"].ToString(),
                        Aspiraciones = dataReader["Aspiraciones"].ToString(),
                        Foto = dataReader["Foto"] as byte[],
                        Estado = dataReader["Estado"].ToString()
                    };
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }
            finally
            {
                // Liberar recursos
                command.Dispose();
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }

            return candidata;
        }

        public void M_ActualizarCandidata(Candidata candidata)
        {
            try
            {
                sqlConnection = conexion.AbrirConexion();
                command = new SqlCommand("sp_ActualizarCandidata", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;

                // Agregar parámetros al comando
                command.Parameters.AddWithValue("@Id", candidata.Id);
                command.Parameters.AddWithValue("@Cedula", candidata.Cedula);
                command.Parameters.AddWithValue("@Nombre", candidata.Nombre);
                command.Parameters.AddWithValue("@Apellido", candidata.Apellido);
                command.Parameters.AddWithValue("@Edad", candidata.Edad);
                command.Parameters.AddWithValue("@Correo", candidata.Correo);
                command.Parameters.AddWithValue("@Celular", candidata.Celular);
                command.Parameters.AddWithValue("@Carrera", candidata.Carrera);
                command.Parameters.AddWithValue("@Nivel", candidata.Nivel);
                command.Parameters.AddWithValue("@Pasatiempos", candidata.Pasatiempos);
                command.Parameters.AddWithValue("@Habilidades", candidata.Habilidades);
                command.Parameters.AddWithValue("@Intereses", candidata.Intereses);
                command.Parameters.AddWithValue("@Aspiraciones", candidata.Aspiraciones);
                command.Parameters.AddWithValue("@Foto", candidata.Foto);
                command.Parameters.AddWithValue("@Estado", candidata.Estado);

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


        public void M_EliminarCandidata(int id)
        {
            try
            {
                sqlConnection = conexion.AbrirConexion();
                command = new SqlCommand("sp_EliminarCandidata", sqlConnection);
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

        public List<int> ObtenerConteoVotosPorCandidata(int candidataId)
        {
            List<int> conteos = new List<int>();

            try
            {
                sqlConnection = conexion.AbrirConexion();
                command = new SqlCommand("sp_ContarVotosPorCandidata", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CandidataId", candidataId);

                dataReader = command.ExecuteReader();

                if (dataReader.Read())
                {
                    // Leer los conteos de votos desde el resultado del procedimiento almacenado
                    int votosFotogenia = dataReader.GetInt32(dataReader.GetOrdinal("VotosFotogenia"));
                    int votosReina = dataReader.GetInt32(dataReader.GetOrdinal("VotosReina"));

                    // Agregar los resultados a la lista
                    conteos.Add(votosFotogenia);
                    conteos.Add(votosReina);
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

            return conteos;
        }

    }
}
