using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dato
{
    public class Conexion
    {
        private readonly string cadenaConexion = "Data Source=localhost\\SQLEXPRESS;Database=BD_REINA_FACULTAD;Integrated Security=true";
        private SqlConnection conexion;

        public SqlConnection AbrirConexion()
        {
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
                throw; // Lanza la excepción para que sea manejada en capas superiores
            }
        }

        public void CerrarConexion()
        {
            try
            {
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR al cerrar la conexión: " + ex.Message);
                throw; // Lanza la excepción para que sea manejada en capas superiores
            }
        }
    }

}