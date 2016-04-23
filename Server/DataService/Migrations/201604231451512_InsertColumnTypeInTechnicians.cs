namespace DataService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertColumnTypeInTechnicians : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Technicians", "Type", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Technicians", "Type");
        }
    }
}
