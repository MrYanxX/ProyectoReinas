using Model.Dato;
using Model.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class CtrComentario
    {
        private DatoComentario datoComentario = new DatoComentario();

        public void RegistrarComentario(Comentario comentario)
        {
            datoComentario.M_RegistrarComentario(comentario);

        }

    }
}
