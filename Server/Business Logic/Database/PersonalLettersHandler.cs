using System.Collections.Generic;
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

        public List<User> Get()
        {
            return _uow.UserRepository.Get().ToContracts();
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
