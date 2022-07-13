using Microsoft.AspNetCore.Mvc;
using HyperDevCase.Models;
using Values.Controllers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860


namespace HyperDevCase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly CaseContext _context;
        private DBCase dBCase;
        //private readonly CaseContext _context;
        //private DBCompany dBCompany;
        public ValuesController(CaseContext context)
        {
            _context = context;
            dBCase = new DBCase(_context);
        }

        // GET: api/<CaseAPI>
        [HttpGet]
        public IEnumerable<Department> Get(int departmentid, int companyid)
        {
            switch (companyid)
            {
                case 1:
                    return dBCase.Control(departmentid);
               
            }
            return null;
        }
        //GET api/<CaseAPI>/5


        // POST api/<CaseAPI>
        //[HttpPost]
        //public void Post(string departmentName, string companyid)
        //{
        //    return dbCompany.Control(departmentName, companyid);

        //}


        // DELETE api/<CaseAPI>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return dBCase.DeleteDepartment(id);
        }


    }
}

