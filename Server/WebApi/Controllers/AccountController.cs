using System.Web.Http;
using Business_Logic.Account;

namespace Server.Controllers
{
    [AllowAnonymous]
    public class AccountController : ApiController
    {
        private LoginHandler _loginHandler;

        public AccountController()
        {
            _loginHandler = new LoginHandler();
        }

        public IHttpActionResult Get(string email, string password)
        {
            return Ok(_loginHandler.AttemptLogin(email, password));
        }
    }
}
