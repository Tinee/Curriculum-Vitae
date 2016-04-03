namespace DataService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Third20160403 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Companies", "Password", c => c.String());
            AlterColumn("dbo.Companies", "Website", c => c.String(maxLength: 1000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Companies", "Website", c => c.String(maxLength: 128));
            DropColumn("dbo.Companies", "Password");
        }
    }
}
