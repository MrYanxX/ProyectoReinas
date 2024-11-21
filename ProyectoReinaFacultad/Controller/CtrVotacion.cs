using Model.Dato;
using Model.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class CtrVotacion
    {
        private DtoVotacion dtoVotacion = new DtoVotacion();

        public bool RegistrarVotacion(Votacion votacion)
        {
            try
            {
                dtoVotacion.registrarVotacion(votacion);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
                return false;
            }
        }

        public bool VerificarVotacion(int id, string datoVoto)
        {
            return dtoVotacion.verificarVotacion(id, datoVoto);
        }

    }
}