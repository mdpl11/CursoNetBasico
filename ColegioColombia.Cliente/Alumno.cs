using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColegioColombia.Cliente
{
    public class Alumno
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public long Cedula { get; set; }

        public int Grado { get; set; }

        public string Grupo { get; set; }
    }
}