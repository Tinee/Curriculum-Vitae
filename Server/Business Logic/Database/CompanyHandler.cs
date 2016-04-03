using System.Collections.Generic;
using Contracts;
using DataLayer.Logic.Database.UnitOfWork;
using Mappers;

namespace Business_Logic.Database
{
    public class CompanyHandler
    {
        private UnitOfWork _uow;

        public List<Company> Get()
        {
            return _uow.CompanyRepository.Get().ToContracts();
        }

        public User Get(int id)
        {
            return _uow.UserRepository.Get(id).ToContract();
        }

        public void Post(User user)
        {
            _uow.UserRepository.CreateOrUpdate(user.ToDatabaseEntitie());
        }

        public void Delete(int id)
        {
            _uow.UserRepository.Delete(id);
        }
    }
}
