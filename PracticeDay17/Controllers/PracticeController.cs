using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PracticeDay17.Models;
namespace PracticeDay17.Controllers
{
    [Route("[controller]")]
    public class PracticeController:ControllerBase
    {
        [HttpGet("info")]
        public List<Employee> Details()
        {
            EmployeeList employeelist = new EmployeeList();
            List<Employee> temp = employeelist.EmployeeDetails();
            return temp;
        }
    }
}