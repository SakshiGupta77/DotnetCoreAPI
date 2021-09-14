using System.Collections.Generic;
using WebAPIAssignment.Models;
using WebAPIAssignment.Repository;
namespace WebAPIAssignment.Models
{
    public class EmployeeData : IEmployee 
    {
        public List<Employee> EmployeeDetails()
        {
            List<Employee> list = new List<Employee>();
            list.Add(new Employee
            {
                EmployeeName="Sakshi",
                EmployeeID=122,
                EmployeePhone=987
            });
            list.Add(new Employee
            {
                EmployeeName="Gupta",
                EmployeeID=123,
                EmployeePhone=098
            });
            return list;
        }
    }
}