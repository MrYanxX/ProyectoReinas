using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Modelo
{
    public class Votacion
    {
        public int Id { get; set; }
        public int CandidataId { get; set; }
        public int EstudianteId { get; set; }
        public string TipoVoto { get; set; }

    }
}
