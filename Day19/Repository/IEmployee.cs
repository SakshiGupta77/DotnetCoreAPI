using Day19.Models;
using System.Collections.Generic;
namespace Day19.Repository
{
    public interface IEmployee
    {
        void Add(Employee employee);
        List<Employee> GetAll();
        Employee Find(int id);
        
    }
}