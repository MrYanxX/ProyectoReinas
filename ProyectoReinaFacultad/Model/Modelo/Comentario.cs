using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Modelo
{
    public class Comentario
    {

        public int Id { get; set; }
        public int FotoId { get; set; }
        public int EstudianteId { get; set; }
        public string TextoComentario { get; set; }

        public Comentario(int fotoId, int estudianteId, string textoComentario)
        {
            FotoId = fotoId;
            EstudianteId = estudianteId;
            TextoComentario = textoComentario;
        }

        public Comentario() { }

    }
}
