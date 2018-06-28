namespace ProjectZorgverzekering.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Arts",
                c => new
                    {
                        ArtsId = c.Int(nullable: false, identity: true),
                        Naam = c.String(),
                        Adresgegevens = c.String(),
                        Email = c.String(),
                        Telefoon = c.String(),
                    })
                .PrimaryKey(t => t.ArtsId);
            
            CreateTable(
                "dbo.Medicaties",
                c => new
                    {
                        MedicatieId = c.Int(nullable: false, identity: true),
                        Naam = c.String(),
                        Beschrijving = c.String(),
                        Bijwerking = c.String(),
                    })
                .PrimaryKey(t => t.MedicatieId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Medicaties");
            DropTable("dbo.Arts");
        }
    }
}
