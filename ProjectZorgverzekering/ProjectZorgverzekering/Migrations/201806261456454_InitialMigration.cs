namespace ProjectZorgverzekering.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Klants", "Naam", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Klants", "Naam");
        }
    }
}
