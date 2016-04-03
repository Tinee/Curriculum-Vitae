using System.Collections.Generic;
using System.Web.Http;
using Business_Logic.Database;
using Contracts;

namespace Server.Controllers
{
    public class CompanyController : ApiController
    {

        private CompanyHandler _companyHandler;

        public CompanyController()
        {
            _companyHandler = new CompanyHandler();
        }
        public IEnumerable<Company> Get()
        {
            return _companyHandler.Get();
        }

        public Company Get(int id)
        {
            return _companyHandler.Get(id);
        }

        public void Post([FromBody]Company company)
        {
            _companyHandler.Post(company);
        }

        public void Delete(int id)
        {
            _companyHandler.Delete(id);
        }
    }
}
