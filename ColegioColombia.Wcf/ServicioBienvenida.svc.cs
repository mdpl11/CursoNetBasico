using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ColegioColombia.Wcf.Models;

namespace ColegioColombia.Wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioBienvenida" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServicioBienvenida.svc or ServicioBienvenida.svc.cs at the Solution Explorer and start debugging.
    public class ServicioBienvenida : IServicioBienvenida
    {
        private readonly List<Alumno> alumnos = new List<Alumno>
        {
            new Alumno { Id= 1, Nombre ="Miguel", Apellido="Peláez", Cedula = 1037587478 },
            new Alumno { Id= 2, Nombre ="Carlos", Apellido="Sanjuan", Cedula = 478475174 },
            new Alumno { Id= 3, Nombre ="Sofia", Apellido="Garcia", Cedula = 43254784 },
        };

        public Alumno ConsultarAlumno(int id)
        {
            Alumno alumno = alumnos.FirstOrDefault(a => a.Id == id);
            return alumno;
        }

        public string SaludoPersonalizado(string nombre)
        {
            int hora = DateTime.Now.Hour;

            nombre = string.IsNullOrEmpty(nombre) ? "Anonimo" : nombre;

            if (hora >= 1 && hora <= 11)
            {
                return $"Buenos días {nombre}";
            }
            else if (hora >= 12 && hora <= 17)
            {
                return $"Buenas tardes {nombre}";
            }

            return $"Buenas noches {nombre}";
        }
    }
}