using  WebAPIAssignment.Models;
using System.Collections.Generic;
namespace WebAPIAssignment.Repository
{
    public interface IEmployee
    {
         List<Employee> EmployeeDetails();
    }
}