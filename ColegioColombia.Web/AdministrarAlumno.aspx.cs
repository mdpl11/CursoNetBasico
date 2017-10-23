using ColegioColombia.Web.DataAccess;
using ColegioColombia.Web.Model;
using System;

namespace ColegioColombia.Web
{
    public partial class AdministrarAlumno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnAdministrarAlumno_Click(object sender, EventArgs e)
        {
            var alumno = new Alumno()
            {
                Nombre = "Laura",
                Apellido = "Villa",
                Cedula = 1038333608,
                Grado = 11,
                Grupo = "11C"
            };

            var context = new ColegioColombiaContext();

            context.Alumno.Add(alumno);
            context.SaveChanges();
        }
    }
}