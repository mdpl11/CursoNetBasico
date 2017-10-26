using System.ComponentModel.DataAnnotations.Schema;

namespace ColegioColombia.Mvc.Models
{
    [Table("Profesores")]
    public class Profesor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public long Cedula { get; set; }
        public string Catedra { get; set; }
    }
}