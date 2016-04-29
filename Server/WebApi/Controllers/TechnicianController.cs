using System.Collections.Generic;
using System.Web.Http;
using Business_Logic.Database;
using Contracts;
using DataService;

namespace Server.Controllers
{
    public class TechnicianController : ApiController
    {
        private readonly TechnicianHandler _technicianHandler;

        public TechnicianController()
        {
            _technicianHandler = new TechnicianHandler(new DataContext());
        }

        public IEnumerable<Technician> Get()
        {
            return _technicianHandler.Get();
        }

        public IHttpActionResult Get(int id)
        {
            var company = _technicianHandler.Get(id);

            if (company == null) return NotFound();
            return Ok(company);
        }
        [Authorize]
        public IHttpActionResult Post(Technician technician)
        {
            _technicianHandler.Post(technician);
            return Ok();
        }
        [Authorize]
        public IHttpActionResult Delete(int id)
        {
            _technicianHandler.Delete(id);
            return Ok();
        }
    }
}
