namespace ejemplo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modelos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Modelos",
                c => new
                    {
                        modeloID = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        costo = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ram = c.String(),
                        procesador = c.String(),
                        discoDuro = c.String(),
                        dimenciones = c.String(),
                    })
                .PrimaryKey(t => t.modeloID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Modelos");
        }
    }
}
