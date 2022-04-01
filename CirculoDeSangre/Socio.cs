using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirculoDeSangre
{
    internal class Socio
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public long DNI { get; set; }
        public string Nacimiento { get; set; }
        public string Domicilio { get; set; }
        public string Localidad { get; set; }
        public long Telefono { get; set; }
        public string Email { get; set; }
        public bool Enfermedad { get; set; }
        public bool Medicamentos { get; set; }

    }
}
