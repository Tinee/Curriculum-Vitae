using DataLayer.Logic.Database.UnitOfWork;
using DataService;

namespace Business_Logic.Database
{
    public class Users
    {
        UnitOfWork _uow;

        public Users(DataContext dataContext)
        {
            _uow = new UnitOfWork(dataContext);
        }

    }
}
