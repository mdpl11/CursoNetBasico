using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ColegioColombia.Wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioBienvenida" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServicioBienvenida.svc or ServicioBienvenida.svc.cs at the Solution Explorer and start debugging.
    public class ServicioBienvenida : IServicioBienvenida
    {
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