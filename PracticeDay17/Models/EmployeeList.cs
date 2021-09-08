using System.Collections.Generic;
using PracticeDay17.Models;
namespace PracticeDay17.Models
{
    public class EmployeeList
    {
        public List<Employee> EmployeeDetails()
        {
            List<Employee> list = new List<Employee>();
            list.Add(new Employee
                {
                    phone = 123,
                    name = "SAkshi"
                });
            list.Add(new Employee
                {
                    phone = 456,
                    name = "Sharma"
                });
            return list;
        }
    }
}