using Microsoft.AspNetCore.Mvc;
using WebAPIAssignment.Models;
using WebAPIAssignment.Repository;
using System.Collections.Generic;
namespace WebAPIAssignment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController: ControllerBase
    {
        IEmployee data;
        public EmployeeController(IEmployee idata)
        {
            data = idata;
        }
        [HttpPost]
        public List<Employee> AddData(List<Employee> tim)
        {
            var t = data.EmployeeDetails();
            return t;
        }
    }
}