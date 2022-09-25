using System.Data.Entity;

namespace Infraestructura.Models
{
    public class EvaluacionTecnicaDbContext:DbContext
    {
        public EvaluacionTecnicaDbContext():base("usuariocontext")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<EvaluacionTecnicaDbContext>(new CreateDatabaseIfNotExists<EvaluacionTecnicaDbContext>());
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Role> Role { get; set; }
    }
}
