using System.Collections.Generic;
using System.Linq;
using Contracts;
using DataLayer.Logic.Database.UnitOfWork;
using DataService;
using Mappers;

namespace Business_Logic.Database
{
    public class PersonalLettersHandler
    {
        private UnitOfWork _uow;
        public PersonalLettersHandler(object dataContext)
        {
            _uow = new UnitOfWork((DataContext)dataContext);
        }

        public List<PersonalLetter> Get()
        {
            return _uow.PersonalLetterRepository.Get().ToContracts();
        }

        public PersonalLetter Get(string companyPassword)
        {
            var companyId = _uow.CompanyRepository.Get(x => x.Password == companyPassword).FirstOrDefault()?.Id;
            return companyId == null ? null :  _uow.PersonalLetterRepository.GetAll().FirstOrDefault(x => x.Company.Id == companyId).ToContract();
        }

        public PersonalLetter Get(int companyId)
        {
          var personalLetter =  _uow.PersonalLetterRepository.Get(x => x.Company.Id == companyId).FirstOrDefault();
            return personalLetter?.ToContract();
        }

        public void Post(PersonalLetter personalLetter)
        {
            _uow.PersonalLetterRepository.CreateOrUpdate(personalLetter.ToDatabaseEntitie());
        }

        public void Delete(int id)
        {
            var personalLetter = _uow.PersonalLetterRepository.Get(id);
            personalLetter.Active = false;
            _uow.PersonalLetterRepository.CreateOrUpdate(personalLetter);
        }
    }
}
