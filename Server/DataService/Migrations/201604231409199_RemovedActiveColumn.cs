namespace DataService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedActiveColumn : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Technicians", "Name", c => c.String(nullable: false));
            DropColumn("dbo.Companies", "Active");
            DropColumn("dbo.PersonalLetters", "Active");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PersonalLetters", "Active", c => c.Boolean(nullable: false));
            AddColumn("dbo.Companies", "Active", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Technicians", "Name", c => c.String());
        }
    }
}
