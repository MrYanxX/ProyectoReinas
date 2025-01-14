using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Modelo
{
    public class Estudiante
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string Matricula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Contraseña { get; set; }
        public string Estado { get; set; }

        // Propiedad de navegación para Usuario
        public Usuario Usuario { get; set; }
    }
}
