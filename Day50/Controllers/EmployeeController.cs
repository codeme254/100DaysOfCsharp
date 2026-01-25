using Microsoft.AspNetCore.Mvc;

namespace MyFirstWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public string GetEmployee()
        {
            return "This action gets an employee";
        }

        [HttpPost]
        public string CreateEmployee()
        {
            return "This action creates an employee";
        }

        [HttpPatch]
        public string PartialUpdateEmployee()
        {
            return "This action partially updates an employee";
        }

        [HttpPut]
        public string UpdateEmployee()
        {
            return "This action updates all the details of an employee";
        }

        [HttpDelete]
        public string DeleteEmployee()
        {
            return "This action deletes an employee";
        }
    }
}