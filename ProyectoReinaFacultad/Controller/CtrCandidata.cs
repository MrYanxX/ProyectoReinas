using Model.Dato;
using Model.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class CtrCandidata
    {
        private DatoCandidata datoCandidata = new DatoCandidata();

        public bool RegistrarCandidata(Candidata candidata)
        {
            try
            {
                candidata.Estado = "Activo";  // Activo por defecto
                datoCandidata.M_RegistrarCandidata(candidata);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
                return false;
            }
        }

        public List<Candidata> ConsultarCandidatas(string cedula, string estado)
        {
            try
            {
                return datoCandidata.ConsultarCandidatas(cedula, estado);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
                return new List<Candidata>();
            }
        }

        public List<Candidata> consultarCandidatasPorNombre(string nombre)
        {
            try
            {
                return datoCandidata.ConsultarCandidatasPorNombre(nombre);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
                return new List<Candidata>();
            }
        }

        public Candidata ConsultarCandidatasPorId(int id)
        {
            try
            {
                return datoCandidata.ConsultarCandidataPorId(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
                return new Candidata();
            }
        }

        public bool ActualizarCandidata(Candidata candidata)
        {
            try
            {
                datoCandidata.M_ActualizarCandidata(candidata);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
                return false;
            }
        }


        public bool EliminarCandidata(int id)
        {
            try
            {
                datoCandidata.M_EliminarCandidata(id);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
                return false;
            }
        }

        public List<int> obtenerVotos(int idCandidata)
        {
            return datoCandidata.ObtenerConteoVotosPorCandidata(idCandidata);
        }

    }
}
