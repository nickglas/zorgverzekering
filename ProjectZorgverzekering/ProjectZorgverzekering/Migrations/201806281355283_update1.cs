namespace ProjectZorgverzekering.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contracts",
                c => new
                    {
                        ContractId = c.Int(nullable: false, identity: true),
                        Dokter = c.String(),
                        Functie = c.String(),
                        Afloopdatum = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ContractId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Contracts");
        }
    }
}
