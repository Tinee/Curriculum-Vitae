namespace DataService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TableAdmin : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false, maxLength: 300),
                        Firstname = c.String(nullable: false, maxLength: 128),
                        Lastname = c.String(nullable: false, maxLength: 128),
                        Password = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Admins");
        }
    }
}
