using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Modelo
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Contraseña { get; set; }
        public int RolId { get; set; }
        public string Estado { get; set; }


    }
}
