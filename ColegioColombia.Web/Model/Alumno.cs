using System.ComponentModel.DataAnnotations.Schema;

namespace ColegioColombia.Web.Model
{
    [Table("Alumnos")]
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