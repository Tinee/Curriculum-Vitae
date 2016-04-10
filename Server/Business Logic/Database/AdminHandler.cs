using System.Collections.Generic;
using Contracts;
using DataLayer.Logic.Database.UnitOfWork;
using DataService;
using Mappers;

namespace Business_Logic.Database
{
    public class AdminHandler
    {
        private UnitOfWork _uow;

        public AdminHandler(object dataContext)
        {
            _uow = new UnitOfWork((DataContext)dataContext);
        }

        public List<Admin> Get()
        {
            return _uow.AdminRepository.Get().ToContracts();
        }

        public Admin Get(int id)
        {
            return _uow.AdminRepository.Get(id).ToContract();
        }

        public void Post(Admin admin)
        {
            _uow.AdminRepository.CreateOrUpdate(admin.ToDatabaseEntitie());
        }

        public void Delete(int id)
        {
            _uow.AdminRepository.Delete(id);
        }
    }
}
