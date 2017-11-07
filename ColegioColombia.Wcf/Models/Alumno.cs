using System.Runtime.Serialization;

namespace ColegioColombia.Wcf.Models
{
    [DataContract]
    public class Alumno
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Nombre { get; set; }

        [DataMember]
        public string Apellido { get; set; }

        [DataMember]
        public long Cedula { get; set; }

        public int Grado { get; set; }

        public string Grupo { get; set; }
    }
}