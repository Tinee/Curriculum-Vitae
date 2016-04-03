
using System.Collections.Generic;
using System.Linq;
using Contracts;

namespace Mappers
{
    public static class Mapper
    {
        #region ToContracts

        #region ListMappers

        public static List<User> ToContracts(this IEnumerable<Database_Entities.User> users)
        {
            var listUsers = users.ToList();
            return listUsers.ConvertAll(x => new User
            {
                Id = x.Id,
                Email = x.Email,
                Firstname = x.Firstname,
                Lastname = x.Lastname
            });
        }

        public static List<Company> ToContracts(this IEnumerable<Database_Entities.Company> companies)
        {
            var listUsers = companies.ToList();
            return listUsers.ConvertAll(x => new Company
            {
                Id = x.Id,
                Name = x.Name,
                Website = x.Website
            });
        }

        public static List<PersonalLetter> ToContracts(this IEnumerable<Database_Entities.PersonalLetter> personalLetters)
        {
            var listUsers = personalLetters.ToList();
            return listUsers.ConvertAll(x => new PersonalLetter
            {
               Id = x.Id,
               Active = x.Active,
               Company = x.Company.ToContract(),
               ContactPerson = x.ContactPerson.ToContract(),
               Description = x.Description,
               LoginCount = x.LoginCount,
               Permission = x.Permission
            });
        }

        #endregion


        #region ObjectMappers

        public static User ToContract(this Database_Entities.User user)
        {
            return new User
            {
                Email = user.Email,
                Firstname = user.Firstname,
                Id = user.Id,
                Lastname = user.Lastname
            };
        }

        public static Company ToContract(this Database_Entities.Company company)
        {
            return new Company
            {
                Name = company.Name,
                Id = company.Id,
                Website = company.Website
            };
        }

        public static PersonalLetter ToContract(this Database_Entities.PersonalLetter personalLetter)
        {
            return new PersonalLetter
            {
                Active = personalLetter.Active,
                Company = personalLetter.Company.ToContract(),
                ContactPerson = personalLetter.ContactPerson.ToContract(),
                Description = personalLetter.Description,
                Id = personalLetter.Id,
                LoginCount = personalLetter.LoginCount,
                Permission = personalLetter.Permission
            };
        }

        #endregion


        #endregion


        #region ToDatabaseEntities

        #region ListMappers

        public static List<Database_Entities.User> ToDatabaseEntities(this IEnumerable<User> users)
        {
            var listUsers = users.ToList();
            return listUsers.ConvertAll(x => new Database_Entities.User
            {
                Id = x.Id,
                Email = x.Email,
                Firstname = x.Firstname,
                Lastname = x.Lastname
            });
        }

        public static List<Database_Entities.Company> ToDatabaseEntities(this IEnumerable<Company> companies)
        {
            var listUsers = companies.ToList();
            return listUsers.ConvertAll(x => new Database_Entities.Company
            {
                Website = x.Website,
                Id = x.Id,
                Name = x.Name
            });
        }

        public static List<Database_Entities.PersonalLetter> ToDatabaseEntities(this IEnumerable<PersonalLetter> personalLetters)
        {
            var listLetters = personalLetters.ToList();
            return listLetters.ConvertAll(x => new Database_Entities.PersonalLetter
            {
                Active = x.Active,
                Company = x.Company.ToDatabaseEntitie(),
                ContactPerson = x.ContactPerson.ToDatabaseEntitie(),
                Description = x.Description,
                Id = x.Id,
                LoginCount = x.LoginCount,
                Permission = x.Permission
            });
        }

        #endregion

        #region ObjectMappers

        public static Database_Entities.User ToDatabaseEntitie(this User user)
        {
            return new Database_Entities.User
            {
                Email = user.Email,
                Firstname = user.Firstname,
                Id = user.Id,
                Lastname = user.Lastname
            };
        }

        public static Database_Entities.Company ToDatabaseEntitie(this Company company)
        {
            return new Database_Entities.Company
            {
                Website = company.Website,
                Id = company.Id,
                Name = company.Name
            };
        }

        public static Database_Entities.PersonalLetter ToDatabaseEntitie(this PersonalLetter personalLetter)
        {
            return new Database_Entities.PersonalLetter
            {
                Active = personalLetter.Active,
                Company = personalLetter.Company.ToDatabaseEntitie(),
                ContactPerson = personalLetter.ContactPerson.ToDatabaseEntitie(),
                Description = personalLetter.Description,
                Id = personalLetter.Id,
                LoginCount = personalLetter.LoginCount,
                Permission = personalLetter.Permission
            };
        }

        #endregion

        #endregion

    }
}
