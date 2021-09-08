using Microsoft.AspNetCore.Mvc;
using EmployeeService.Models;
namespace EmployeeService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController:ControllerBase
    {
        [HttpPost("Create")]
        public Employee CreateEmployee(Employee empobj)
        {
            return empobj;
        }
    }
}