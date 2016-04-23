using System.Collections.Generic;
using Business_Logic.Account;
using Contracts;
using DataService;
using DataService.UnitOfWork;
using Mappers;

namespace Business_Logic.Database
{
    public class CompanyHandler
    {
        private UnitOfWork _uow;

        public CompanyHandler(object dataContext)
        {
            _uow = new UnitOfWork((DataContext)dataContext);
        }

        public List<Company> Get()
        {
            return _uow.CompanyRepository.Get().ToContracts();
        }

        public Company Get(int id)
        {
            return _uow.CompanyRepository.Get(id).ToContract();
        }

        public void Post(Company company)
        {
            company.Password = PasswordHandler.CreatePassword();
            _uow.CompanyRepository.CreateOrUpdate(company.ToDatabaseEntitie());
        }

        public void Delete(int id)
        {
            _uow.CompanyRepository.Delete(id);
        }
    }
}
