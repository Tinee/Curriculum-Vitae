using System.Collections.Generic;
using System.Web.Http;
using Business_Logic.Database;
using Contracts;
using DataService;

namespace Server.Controllers
{
    public class PersonalLetterController : ApiController
    {
        private PersonalLettersHandler _personalLetterHandler;

        public PersonalLetterController()
        {
            _personalLetterHandler = new PersonalLettersHandler(new DataContext());
        }
        public List<User> Get()
        {
            return _personalLetterHandler.Get();
        }

        public User Get(int id)
        {
            return _personalLetterHandler.Get(id);
        }

        public void Post([FromBody]User user)
        {
            _personalLetterHandler.Post(user);
        }

        public void Delete(int id)
        {
            _personalLetterHandler.Delete(id);
        }
    }
}
