using System.Collections.Generic;
using EmployeesService.Models;
namespace EmployeesService.Models
{
    public class EmployeeData
    {
        public List<Employee> EmployeeDetails()
        {
            List<Employee> list = new List<Employee>();
            list.Add(new Employee
            {
                phone=3423,
                name="Sakshi"
            });
            list.Add(new Employee
            {
                phone=2323,
                name="Gupta"
            });
            return list;
        } 
    }
}