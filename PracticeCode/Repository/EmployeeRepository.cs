using System.Collections.Generic;
using PracticeCode.Models;
using PracticeCode.Repository;
using System.Linq;

namespace PracticeCode.Repository
{
    public class EmployeeRepository : IEmployee
    {
        List<Employee> listEmployee = new List<Employee>();
        void IEmployee.Add(Employee employee)
        {
            listEmployee.Add(employee);
        }

        Employee IEmployee.Find(int id)
        {
            var employee = listEmployee.Where(ctr=>ctr.EmployeeID==id).SingleOrDefault();
            return employee;
        }
    }
}