using ColegioColombia.Web.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ColegioColombia.Web.DataAccess
{
    public class ColegioColombiaContext : DbContext
    {
        public DbSet<Alumno> Alumno { get; set; }
        public DbSet<Profesor> Profesor { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}