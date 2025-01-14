using Model.Dato;
using Model.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controller
{
    public class CtrEstudiante
    {
        private DatoEstudiante datoEstudiante = new DatoEstudiante();

        public bool RegistrarEstudiante(Estudiante estudiante)
        {
            try
            {
                estudiante.Estado = "Activo";  // Activo
                datoEstudiante.M_RegistrarEstudiante(estudiante);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
                return false;
            }
        }


        public List<Estudiante> ConsultarEstudiantes(string cedula, string estado)
        {
            try
            {
                return datoEstudiante.ConsultarEstudiantes(cedula, estado);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
                return new List<Estudiante>();
            }
        }

        public bool ActualizarEstudiante(Estudiante estudiante)
        {
            try
            {
                datoEstudiante.M_ActualizarEstudiante(estudiante);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
                return false;
            }
        }


        public bool EliminarEstudiante(int id)
        {
            try
            {
                datoEstudiante.M_EliminarEstudiante(id);
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
