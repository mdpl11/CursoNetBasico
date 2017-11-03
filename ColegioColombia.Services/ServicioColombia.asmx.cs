using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ColegioColombia.Services
{
    /// <summary>
    /// Summary description for ServicioColombia
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
    // [System.Web.Script.Services.ScriptService]
    public class ServicioColombia : System.Web.Services.WebService
    {
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string Saludo(string nombre)
        {
            return $"Hola {nombre}";
        }

        [WebMethod]
        public string SaludoPersonalizado(string nombre)
        {
            int hora = DateTime.Now.Hour;

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

        [WebMethod]
        public decimal Sumar(decimal a, decimal b)
        {
            return (a + b);
        }

        [WebMethod]
        public decimal Restar(decimal a, decimal b)
        {
            return (a - b);
        }

        [WebMethod]
        public decimal Multiplicar(decimal a, decimal b)
        {
            return a * b;
        }

        [WebMethod]
        public decimal Dividir(decimal a, decimal b)
        {
            //if (B == 0) { return -1; }

            //return Convert.ToDecimal(A / B);

            return b == 0 ? -1 : Convert.ToDecimal(a / b);
        }
    }
}