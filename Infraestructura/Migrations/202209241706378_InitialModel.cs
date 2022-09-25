namespace Infraestructura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 200),
                        Usuario_Transaccion = c.String(),
                        Fecha_Transaccion = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RolId = c.Int(nullable: false),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Cedula = c.String(maxLength: 16),
                        Usuario_Nombre = c.String(maxLength: 200),
                        Contrasena = c.String(),
                        Fecha_Nacimiento = c.DateTime(),
                        Usuario_Transaccion = c.String(),
                        Fecha_Transaccion = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.RolId, cascadeDelete: true)
                .Index(t => t.RolId)
                .Index(t => t.Cedula, unique: true, name: "Index_unique_01")
                .Index(t => t.Usuario_Nombre, unique: true, name: "Index_unique_02")
                .Index(t => t.Fecha_Nacimiento);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuario", "RolId", "dbo.Roles");
            DropIndex("dbo.Usuario", new[] { "Fecha_Nacimiento" });
            DropIndex("dbo.Usuario", "Index_unique_02");
            DropIndex("dbo.Usuario", "Index_unique_01");
            DropIndex("dbo.Usuario", new[] { "RolId" });
            DropTable("dbo.Usuario");
            DropTable("dbo.Roles");
        }
    }
}
