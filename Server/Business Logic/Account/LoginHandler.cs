using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Contracts;
using DataLayer.Logic.Database.UnitOfWork;
using DataService;
using Mappers;

namespace Business_Logic.Account
{
    public class LoginHandler
    {
        private UnitOfWork _uow;

        public LoginHandler(object datacontext)
        {
            _uow = new UnitOfWork((DataContext)datacontext);
        }
        public bool AttemptLogin(int companyId, string password)
        {
            var company = _uow.CompanyRepository.Get(companyId);

            if (company == null) return false;
            if (company.Password != password) return false;

            return true;
        }
    }
}
