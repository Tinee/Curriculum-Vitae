using System.Web.Http;
using Business_Logic.Database;
using Contracts;
using DataService;

namespace Server.Controllers
{
    [Authorize]
    public class CompaniesController : ApiController
    {
        private readonly CompanyHandler _companyHandler;

        public CompaniesController()
        {
            _companyHandler = new CompanyHandler(new DataContext());
        }

        public IHttpActionResult Get()
        {
            return Ok(_companyHandler.Get());
        }

        public IHttpActionResult Get(int id)
        {
            var company = _companyHandler.Get(id);

            if(company == null) return NotFound();
            return Ok(company);
        }

        public IHttpActionResult Post(Company company)
        {
            _companyHandler.Post(company);
            return Ok();
        }
    }
}
