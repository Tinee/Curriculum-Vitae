namespace DataService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First20160403 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 128),
                        Website = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PersonalLetters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false),
                        LoginCount = c.Int(nullable: false),
                        Active = c.Boolean(nullable: false),
                        Company_Id = c.Int(),
                        ContactPerson_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.Company_Id)
                .ForeignKey("dbo.Users", t => t.ContactPerson_Id)
                .Index(t => t.Company_Id)
                .Index(t => t.ContactPerson_Id);
            
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
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.Company_Id)
                .Index(t => t.Company_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PersonalLetters", "ContactPerson_Id", "dbo.Users");
            DropForeignKey("dbo.Users", "Company_Id", "dbo.Companies");
            DropForeignKey("dbo.PersonalLetters", "Company_Id", "dbo.Companies");
            DropIndex("dbo.Users", new[] { "Company_Id" });
            DropIndex("dbo.PersonalLetters", new[] { "ContactPerson_Id" });
            DropIndex("dbo.PersonalLetters", new[] { "Company_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.PersonalLetters");
            DropTable("dbo.Companies");
        }
    }
}
