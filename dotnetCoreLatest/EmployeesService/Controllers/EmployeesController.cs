using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using EmployeesService.Models;
using EmployeesService.Models;
namespace EmployeesService.Controllers
{
    [Route("[controller]")]
    public class EmployeesController:ControllerBase
    {
        [HttpGet("Info")]
        public List<Employee> Detailss()
        {
            EmployeeData obj = new EmployeeData();
            List<Employee> temp = obj.EmployeeDetails();
            return temp;
        }
    }    
}