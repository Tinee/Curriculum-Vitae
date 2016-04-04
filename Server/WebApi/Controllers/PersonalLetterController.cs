using System.Collections.Generic;
using System.Web.Http;
using Business_Logic.Database;
using Contracts;
using DataService;
using Microsoft.Ajax.Utilities;

namespace Server.Controllers
{
    public class PersonalLetterController : ApiController
    {
        private PersonalLettersHandler _personalLetterHandler;

        public PersonalLetterController()
        {
            _personalLetterHandler = new PersonalLettersHandler(new DataContext());
        }

        [Route("api/personalLetter/{companyPassword}")]
        public IHttpActionResult GetByCompanyPassword(string companyPassword)
        {
            var response = _personalLetterHandler.Get(companyPassword);

            if (response == null) return BadRequest();
            return Ok(response);
        }

        public void Post([FromBody]PersonalLetter personalLetter)
        {
            _personalLetterHandler.Post(personalLetter);
        }

        public void Delete(int id)
        {
            _personalLetterHandler.Delete(id);
        }
    }
}
