using System.Collections.Generic;
using System.Web.Http;
using Business_Logic.Database;
using Contracts;
using DataService;

namespace Server.Controllers
{
    public class CompanyController : ApiController
    {

        private CompanyHandler _companyHandler;

        public CompanyController()
        {
            _companyHandler = new CompanyHandler(new DataContext());
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
