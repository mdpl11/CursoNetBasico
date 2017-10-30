using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ColegioColombia.Mvc.Models
{
    [Table("Alumnos")]
    public class Alumno
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "El nombre no puede superar 10 caracteres")]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(10, ErrorMessage = "El nombre no puede superar 10 caracteres")]
        public string Apellido { get; set; }

        [Required]
        public long Cedula { get; set; }

        [Range(6, 11)]
        [Required]
        public int Grado { get; set; }

        [Display(Prompt = "Código del Grupo del Alumno.", Name = "Código del Grupo")]
        public string Grupo { get; set; }
    }
}