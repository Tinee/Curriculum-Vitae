using Database_Entities;

namespace DataService.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataService.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataService.DataContext context)
        {
            var company = new Company
            {
                Id = 1,
                Name = "It-Mästaren",
                Website = "Itmastaren.se",
                Password = "itm"
            };
            
            var user = new User
            {
                Id = 1,
                Firstname = "Marcus",
                Lastname = "Carlsson",
                Email = "Marcus.Caarlsson92@gmail.com",
                
                Phone = "0763074962",
                Company = company
            };

            context.Companies.AddOrUpdate(company);
            context.Users.AddOrUpdate(user);
        }
    }
}
