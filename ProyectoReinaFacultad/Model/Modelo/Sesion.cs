using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Modelo
{
    public class Sesion
    {
        public string Usuario { get; set; }  // Nombre de usuario
        public string Contraseña { get; set; }

        public Sesion(string usuario, string contraseña)
        {
            Usuario = usuario;
            Contraseña = contraseña;
        }
    }
}
