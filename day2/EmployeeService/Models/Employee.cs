using System.ComponentModel.DataAnnotations;
namespace EmployeeService.Models
{
    public class Employee
    {
        public int EmployeeCode{get;set;}
        public string EmployeeName{get;set;}
        //[Range(21,45)]
        [Required]  
        public int EmployeeAge{get;set;}
    }
}