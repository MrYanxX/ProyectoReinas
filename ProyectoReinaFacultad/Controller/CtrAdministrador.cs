using Model.Dato;
using Model.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class CtrAdministrador
    {
        private DatoAdministrador datoAdministrador = new DatoAdministrador();

        public bool RegistrarAdministrador(Administrador administrador)
        {
            try
            {
                administrador.Estado = "Activo";  // Activo
                datoAdministrador.M_RegistrarAdministrador(administrador);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
                return false;
            }
        }


        public List<Administrador> ConsultarAdministradores(string cedula, string estado)
        {
            try
            {
                return datoAdministrador.ConsultarAdministradores(cedula, estado);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
                return new List<Administrador>();
            }
        }

        public bool ActualizarAdministrador(Administrador administrador)
        {
            try
            {
                datoAdministrador.M_ActualizarAdministrador(administrador);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
                return false;
            }
        }


        public bool EliminarAdministrador(int id)
        {
            try
            {
                datoAdministrador.M_EliminarAdministrador(id);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
                return false;
            }
        }


    }
}
