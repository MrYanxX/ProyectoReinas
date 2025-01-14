using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Modelo
{
    public class Candidata
    {
        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Edad { get; set; }
        public string Correo { get; set; }
        public string Celular { get; set; }
        public string Carrera { get; set; }
        public string Nivel { get; set; }
        public string Pasatiempos { get; set; }
        public string Habilidades { get; set; }
        public string Intereses { get; set; }
        public string Aspiraciones { get; set; }
        public byte[] Foto { get; set; }
        public string Estado { get; set; }

    }
}
