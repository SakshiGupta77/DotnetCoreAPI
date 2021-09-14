using PracticeCode.Models;
using System.Collections.Generic;
namespace PracticeCode.Repository
{
    public interface IEmployee
    {
         void Add(Employee employee);
         List<Employee> GetAll();
         Employee Find(int id);
         void Update(Employee employee);
         void Remove (int id);
    }
}