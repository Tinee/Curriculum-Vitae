using System.Collections.Generic;
using System.Linq;
using Contracts;
using DataService;
using DataService.UnitOfWork;
using Mappers;

namespace Business_Logic.Database
{
    public class TechnicianHandler
    {
        private readonly UnitOfWork _uow;
        public TechnicianHandler(object dataContext)
        {
            _uow = new UnitOfWork((DataContext)dataContext);
        }

        public List<Technician> Get()
        {
            return _uow.TechnicianRepository.Get().ToContracts();
        }

        public Technician Get(int id)
        {
            var technician = _uow.TechnicianRepository.Get(x => x.Id == id).FirstOrDefault();
            return technician?.ToContract();
        }

        public void Post(Technician technician)
        {
            _uow.TechnicianRepository.CreateOrUpdate(technician.ToDatabaseEntitie());
        }

        public void Delete(int id)
        {
            _uow.TechnicianRepository.Delete(id);
        }
    }
}
