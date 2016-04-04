namespace DataService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewDb20160404 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Users", "Company_Id", "dbo.Companies");
            DropForeignKey("dbo.PersonalLetters", "ContactPerson_Id", "dbo.Users");
            DropIndex("dbo.PersonalLetters", new[] { "ContactPerson_Id" });
            DropIndex("dbo.Users", new[] { "Company_Id" });
            DropColumn("dbo.PersonalLetters", "Permission");
            DropColumn("dbo.PersonalLetters", "ContactPerson_Id");
            DropTable("dbo.Users");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Firstname = c.String(maxLength: 128),
                        Lastname = c.String(maxLength: 128),
                        Phone = c.String(),
                        Email = c.String(),
                        Company_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.PersonalLetters", "ContactPerson_Id", c => c.Int());
            AddColumn("dbo.PersonalLetters", "Permission", c => c.Int(nullable: false));
            CreateIndex("dbo.Users", "Company_Id");
            CreateIndex("dbo.PersonalLetters", "ContactPerson_Id");
            AddForeignKey("dbo.PersonalLetters", "ContactPerson_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.Users", "Company_Id", "dbo.Companies", "Id");
        }
    }
}
