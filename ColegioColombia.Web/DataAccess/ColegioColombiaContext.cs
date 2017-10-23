using ColegioColombia.Web.Model;
using System.Data.Entity;

namespace ColegioColombia.Web.DataAccess
{
    public class ColegioColombiaContext : DbContext
    {
        public DbSet<Alumno> Alumno { get; set; }
        public DbSet<Profesor> Profesor { get; set; }
    }
}