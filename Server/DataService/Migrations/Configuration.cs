using Database_Entities;
using Enums;

namespace DataService.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<DataService.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;

        }

        protected override void Seed(DataService.DataContext context)
        {
            var tec1 = new Technician
            {
                Id = 1,
                Name = "C#",
                Percentage = 96,
                Type = TechnicianType.Technician
            };

            var tec2 = new Technician
            {
                Id = 2,
                Name = "Web-Api",
                Percentage = 93,
                Type = TechnicianType.Technician
            };

            var tec3 = new Technician
            {
                Id = 3,
                Name = "Entity Framework",
                Percentage = 86,
                Type = TechnicianType.Technician
            };

            var tec4 = new Technician
            {
                Id = 5,
                Name = "Code First Migrations",
                Percentage = 75,
                Type = TechnicianType.Technician
            };

            var tec6 = new Technician
            {
                Id = 6,
                Name = "Javascript",
                Percentage = 70,
                Type = TechnicianType.Technician
            };

            var tec7 = new Technician
            {
                Id = 7,
                Name = "Mvc",
                Percentage = 64,
                Type = TechnicianType.Technician
            };

            var tec8 = new Technician
            {
                Id = 8,
                Name = "MS Sql",
                Percentage = 55,
                Type = TechnicianType.Technician
            };

            var tec9 = new Technician
            {
                Id = 9,
                Name = "MongoDb",
                Percentage = 44,
                Type = TechnicianType.Technician
            };

            var tec10 = new Technician
            {
                Id = 10,
                Name = "Wpf",
                Percentage = 43,
                Type = TechnicianType.Technician
            };

            var tec11 = new Technician
            {
                Id = 11,
                Name = "HTML & CSS ",
                Percentage = 42,
                Type = TechnicianType.Technician
            };

            var tec12 = new Technician
            {
                Id = 12,
                Name = "Active Directory",
                Percentage = 40,
                Type = TechnicianType.Technician
            };

            var tec13 = new Technician
            {
                Id = 13,
                Name = "Angular Material Design",
                Percentage = 36,
                Type = TechnicianType.Technician
            };

            var tec14 = new Technician
            {
                Id = 14,
                Name = "Typescript",
                Percentage = 33,
                Type = TechnicianType.Technician
            };

            var tec15 = new Technician
            {
                Id = 15,
                Name = "Microsoft Azure",
                Percentage = 32,
                Type = TechnicianType.Technician
            };



            var java1 = new Technician
            {
                Id = 16,
                Name = "Angular",
                Percentage = 85,
                Type = TechnicianType.JavascriptLibraries
            };

            var java2 = new Technician
            {
                Id = 17,
                Name = "Ionic",
                Percentage = 60,
                Type = TechnicianType.JavascriptLibraries
            };

            var java3 = new Technician
            {
                Id = 18 ,
                Name = "Node",
                Percentage = 51,
                Type = TechnicianType.JavascriptLibraries
            };

            var java4 = new Technician
            {
                Id = 19 ,
                Name = "Express",
                Percentage = 45,
                Type = TechnicianType.JavascriptLibraries
            };

            var java5 = new Technician
            {
                Id = 20,
                Name = "Meteor",
                Percentage = 30,
                Type = TechnicianType.JavascriptLibraries
            };

            var java6 = new Technician
            {
                Id = 21,
                Name = "Breeze",
                Percentage = 20,
                Type = TechnicianType.JavascriptLibraries
            };

            var devEnviroment1 = new Technician
            {
                Id = 22,
                Name = "Visual Studio Code",
                Percentage = 100,
                Type = TechnicianType.DevelopmentEnviroments
            };

            var devEnviroment2 = new Technician
            {
                Id = 23,
                Name = "Visual Studio 2015",
                Percentage = 80,
                Type = TechnicianType.DevelopmentEnviroments
            };

            var devEnviroment3 = new Technician
            {
                Id = 24,
                Name = "Postman",
                Percentage = 71,
                Type = TechnicianType.DevelopmentEnviroments
            };

            var devEnviroment4 = new Technician
            {
                Id = 25,
                Name = "Sql Server Mangement",
                Percentage = 60,
                Type = TechnicianType.DevelopmentEnviroments
            };


            var devEnviroment5 = new Technician
            {
                Id = 26,
                Name = "GitHub",
                Percentage = 56,
                Type = TechnicianType.DevelopmentEnviroments
            };

            var devEnviroment6 = new Technician
            {
                Id = 27,
                Name = "Git",
                Percentage = 44,
                Type = TechnicianType.DevelopmentEnviroments
            };

            var devEnviroment7 = new Technician
            {
                Id = 28,
                Name = "Team Foundation Server",
                Percentage = 35,
                Type = TechnicianType.DevelopmentEnviroments
            };

            context.Technicians.AddOrUpdate(tec1);
            context.Technicians.AddOrUpdate(tec2);
            context.Technicians.AddOrUpdate(tec3);
            context.Technicians.AddOrUpdate(tec4);
            context.Technicians.AddOrUpdate(tec6);
            context.Technicians.AddOrUpdate(tec7);
            context.Technicians.AddOrUpdate(tec8);
            context.Technicians.AddOrUpdate(tec9);
            context.Technicians.AddOrUpdate(tec10);
            context.Technicians.AddOrUpdate(tec11);
            context.Technicians.AddOrUpdate(tec12);
            context.Technicians.AddOrUpdate(tec13);
            context.Technicians.AddOrUpdate(tec14);
            context.Technicians.AddOrUpdate(tec15);

            context.Technicians.AddOrUpdate(java1);
            context.Technicians.AddOrUpdate(java2);
            context.Technicians.AddOrUpdate(java3);
            context.Technicians.AddOrUpdate(java4);
            context.Technicians.AddOrUpdate(java5);
            context.Technicians.AddOrUpdate(java6);

            context.Technicians.AddOrUpdate(devEnviroment1);
            context.Technicians.AddOrUpdate(devEnviroment2);
            context.Technicians.AddOrUpdate(devEnviroment3);
            context.Technicians.AddOrUpdate(devEnviroment4);
            context.Technicians.AddOrUpdate(devEnviroment5);
            context.Technicians.AddOrUpdate(devEnviroment6);
            context.Technicians.AddOrUpdate(devEnviroment7);
        }
    }
}
