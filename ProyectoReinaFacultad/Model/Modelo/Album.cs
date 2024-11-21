using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Modelo
{
    public class Album
    {
        public int Id { get; set; }
        public int CandidataId { get; set; }
        public Candidata Candidata { get; set; }
        public List<Foto> Fotos { get; set; }  // Lista de fotos en el álbum

        // Constructor opcional para inicializar propiedades
        public Album()
        {
            Fotos = new List<Foto>();
        }
    }
}
