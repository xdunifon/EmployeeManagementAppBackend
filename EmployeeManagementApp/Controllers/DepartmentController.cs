using EmployeeManagementApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace EmployeeManagementApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        //private readonly iconfiguration _configuration;
        //public departmentcontroller(iconfiguration configuration)
        //{
        //    _configuration = configuration;
        //}

        [HttpGet]
        public async Task<ActionResult<List<Department>>> GetAllDepartments()
        {
            var Departments = new List<Department>
            {
                new Department
                {
                    DepartmentId = 1,
                    Name = "IT"
                }
            };

            return Ok(Departments);
        }
    }
}
