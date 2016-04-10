using Database_Entities;

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
            var company = new Company
            {
                Id = 1,
                Name = "It-M�staren",
                Website = "Itmastaren.se",
                Password = "itm",
                Active = true
            };

            var company2 = new Company
            {
                Id = 2,
                Name = "Nethouse",
                Website = "Nethouse.se",
                Password = "nethouse2016personalcv",
                Active = true
            };

            var personalLetterItm = new PersonalLetter
            {
                Active = true,
                Company = company,
                Description = "Jag testar detta s�tt att l�gga till ett personligt cv f�r att allt ska bli simpelt f�r mig att ge ut cv till f�retagen jag s�ker till, jag tror inte p� tomtet och f�rs�ker nu bara skriva s� l�ngt jag kan komma p� f�r att se formatet p� hemsidan n�r den h�mtar data d�r ifr�n. Ha en bra dag s� h�rs vi senare i den fina skogen med m�nga bj�rnar och oxar.",
                Id = 1,
                DownloadCount = 0
            };

            var personalLetterNH = new PersonalLetter
            {
                Active = true,
                Company = company2,
                Description = "Jag testar detta s�tt att l�gga till ett personligt cv f�r att allt ska bli simpelt f�r mig att ge ut cv till f�retagen jag s�ker till, jag tror inte p� tomtet och f�rs�ker nu bara skriva s� l�ngt jag kan komma p� f�r att se formatet p� hemsidan n�r den h�mtar data d�r ifr�n. Ha en bra dag s� h�rs vi senare i den fina skogen med m�nga bj�rnar och oxar.",
                Id = 2,
                DownloadCount = 0
            };

            context.Companies.AddOrUpdate(company);
            context.Companies.AddOrUpdate(company2);
            context.PersonalLetters.AddOrUpdate(personalLetterItm);
            context.PersonalLetters.AddOrUpdate(personalLetterNH);

        }
    }
}
