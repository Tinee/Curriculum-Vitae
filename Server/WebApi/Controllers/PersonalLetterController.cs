using System.Collections.Generic;
using System.Web.Http;

namespace Server.Controllers
{
    public class PersonalLetterController : ApiController
    {
        // GET: api/PersonalLetter
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/PersonalLetter/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/PersonalLetter
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/PersonalLetter/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/PersonalLetter/5
        public void Delete(int id)
        {
        }
    }
}
