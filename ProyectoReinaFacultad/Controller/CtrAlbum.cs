using Model.Dato;
using Model.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class CtrAlbum
    {
        DatoAlbum dtoAlbum = new DatoAlbum();
        public bool RegistrarFotos(List<Foto> fotos, int id)
        {
            try
            {
                dtoAlbum.RegistrarFotos(fotos, id);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
                return false;
            }
        }

        public bool ConsultarAlbum(int id)
        {
            return dtoAlbum.ConsultarAlbum(id);
        }

        public List<Foto> consultarFotos(int id)
        {
            return dtoAlbum.consultarFotos(id);
        }

        public bool actualizarAlbum(List<Foto> fotos)
        {
            return dtoAlbum.actualizarAlbum(fotos);
        }
    }
}
