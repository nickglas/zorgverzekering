namespace ProjectZorgverzekering.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Klants",
                c => new
                    {
                        KlantId = c.Int(nullable: false, identity: true),
                        Adresgegevens = c.String(),
                        Email = c.String(),
                        Verzekering = c.String(),
                    })
                .PrimaryKey(t => t.KlantId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Klants");
        }
    }
}
