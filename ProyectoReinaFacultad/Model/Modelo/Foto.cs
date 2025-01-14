using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Modelo
{
    public class Foto
    {
        public int Id { get; set; }
        public int AlbumId { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public byte[] FotoData { get; set; }

        // Propiedad de navegación para Album
        public Album Album { get; set; }
    }
}
