using Microsoft.AspNetCore.Mvc;

namespace controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController: ControllerBase
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
        public string PatchEmployee()
        {
            return "[Patch] This action updates an employee";
        }

        [HttpPut]
        public string PutEmployee()
        {
            return "[Put] This action updates an employee";
        }

        [HttpDelete]
        public string DeleteEmployee()
        {
            return "This action deletes an employee";
        }
    }
}
