namespace DataService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TableTechnician : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Technicians",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Percentage = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Technicians");
        }
    }
}
