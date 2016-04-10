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
                Name = "It-Mästaren",
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
                Description = "Jag testar detta sätt att lägga till ett personligt cv för att allt ska bli simpelt för mig att ge ut cv till företagen jag söker till, jag tror inte på tomtet och försöker nu bara skriva så långt jag kan komma på för att se formatet på hemsidan när den hämtar data där ifrån. Ha en bra dag så hörs vi senare i den fina skogen med många björnar och oxar.",
                Id = 1,
                DownloadCount = 0
            };

            var personalLetterNH = new PersonalLetter
            {
                Active = true,
                Company = company2,
                Description = "Jag testar detta sätt att lägga till ett personligt cv för att allt ska bli simpelt för mig att ge ut cv till företagen jag söker till, jag tror inte på tomtet och försöker nu bara skriva så långt jag kan komma på för att se formatet på hemsidan när den hämtar data där ifrån. Ha en bra dag så hörs vi senare i den fina skogen med många björnar och oxar.",
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
