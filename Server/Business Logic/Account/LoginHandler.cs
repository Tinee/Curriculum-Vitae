using System.Linq;
using Contracts;
using DataService;
using DataService.UnitOfWork;
using Mappers;

namespace Business_Logic.Account
{
    public class LoginHandler
    {
        private UnitOfWork _uow;

        public LoginHandler()
        {
            _uow = new UnitOfWork(new DataContext());
        }
        public Admin AttemptLogin(string email, string password)
        {
            var admin = _uow.AdminRepository.Get().FirstOrDefault(x => x.Email == email);

            if (admin == null) return null;
            return password != admin.Password ? null : admin.ToContract();
        }
    }
}
