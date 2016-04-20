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

        [Authorize]
        public IEnumerable<PersonalLetter> Get()
        {
            return _personalLetterHandler.Get();
        }

        [AllowAnonymous]
        [Route("api/personalLetter/{companyPassword}")]
        public IHttpActionResult GetByCompanyPassword(string companyPassword)
        {
            var response = _personalLetterHandler.Get(companyPassword);

            if (response == null) return NotFound();

            response.DownloadCount++;
            _personalLetterHandler.Post(response);

            return Ok(response);
        }

        [Authorize]
        [Route("api/personalLetter/GetByCompanyId/{companyId}")]
        public IHttpActionResult Get(int companyId)
        {
            var response = _personalLetterHandler.Get(companyId);

            if (response == null) return NotFound();
            return Ok(response);
        }
        [Authorize]
        public void Post([FromBody]PersonalLetter personalLetter)
        {
            _personalLetterHandler.Post(personalLetter);
        }
    }
}
