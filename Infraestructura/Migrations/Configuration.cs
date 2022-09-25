namespace Infraestructura.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Infraestructura.Models.EvaluacionTecnicaDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Infraestructura.Models.EvaluacionTecnicaDbContext context)
        {
            context.Role.AddRange(DataSeed.Roles);
            context.Usuario.AddRange(DataSeed.Usuarios);

            context.SaveChanges();
        }
    }
}
