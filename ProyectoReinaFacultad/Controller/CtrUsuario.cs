using Model.Dato;
using Model.Modelo;
using System.Linq;

namespace Controller
{
    public class CtrUsuario
    {
        private DatoUsuario datoUsuario = new DatoUsuario();

        public Usuario IniciarSesion(string nombreUsuario, string contraseña)
        {
            return datoUsuario.ValidarUsuario(nombreUsuario, contraseña);
        }

        
    }

}