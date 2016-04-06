namespace DataService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewDbSecond20160406 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Companies", "Active", c => c.Boolean(nullable: false));
            AddColumn("dbo.PersonalLetters", "DownloadCount", c => c.Int(nullable: false));
            DropColumn("dbo.PersonalLetters", "LoginCount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PersonalLetters", "LoginCount", c => c.Int(nullable: false));
            DropColumn("dbo.PersonalLetters", "DownloadCount");
            DropColumn("dbo.Companies", "Active");
        }
    }
}
