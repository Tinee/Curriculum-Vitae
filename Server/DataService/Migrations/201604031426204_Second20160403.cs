namespace DataService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second20160403 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PersonalLetters", "Company_Id", "dbo.Companies");
            DropIndex("dbo.PersonalLetters", new[] { "Company_Id" });
            AddColumn("dbo.PersonalLetters", "Permission", c => c.Int(nullable: false));
            AlterColumn("dbo.PersonalLetters", "Company_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.PersonalLetters", "Company_Id");
            AddForeignKey("dbo.PersonalLetters", "Company_Id", "dbo.Companies", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PersonalLetters", "Company_Id", "dbo.Companies");
            DropIndex("dbo.PersonalLetters", new[] { "Company_Id" });
            AlterColumn("dbo.PersonalLetters", "Company_Id", c => c.Int());
            DropColumn("dbo.PersonalLetters", "Permission");
            CreateIndex("dbo.PersonalLetters", "Company_Id");
            AddForeignKey("dbo.PersonalLetters", "Company_Id", "dbo.Companies", "Id");
        }
    }
}
