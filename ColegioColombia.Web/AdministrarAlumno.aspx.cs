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
                Nombre = txtNombre.Value,
                Apellido = txtApellido.Value,
                Cedula = int.Parse(txtCedula.Value),
                Grado = int.Parse(txtGrado.Value),
                Grupo = txtGrupo.Value
            };

            var context = new ColegioColombiaContext();

            context.Alumno.Add(alumno);
            context.SaveChanges();
        }
    }
}