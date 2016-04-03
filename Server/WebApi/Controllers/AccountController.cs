using System.Collections.Generic;
using System.Web.Http;
using Business_Logic.Account;
using DataService;

namespace Server.Controllers
{
    public class AccountController : ApiController
    {
        private LoginHandler _loginHandler;

        public AccountController()
        {
            _loginHandler = new LoginHandler(new DataContext());
        }

        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
      
    }
}
