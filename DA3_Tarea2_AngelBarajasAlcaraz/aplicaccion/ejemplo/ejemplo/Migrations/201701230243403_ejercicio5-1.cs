namespace ejemplo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ejercicio51 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Estados",
                c => new
                    {
                        estadoID = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                    })
                .PrimaryKey(t => t.estadoID);
            
            CreateTable(
                "dbo.Municipios",
                c => new
                    {
                        municipioID = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        estadoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.municipioID)
                .ForeignKey("dbo.Estados", t => t.estadoID, cascadeDelete: true)
                .Index(t => t.estadoID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Municipios", "estadoID", "dbo.Estados");
            DropIndex("dbo.Municipios", new[] { "estadoID" });
            DropTable("dbo.Municipios");
            DropTable("dbo.Estados");
        }
    }
}
