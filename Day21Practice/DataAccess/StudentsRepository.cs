using System;
using Day21Practice.Models;
using System.Collections.Generic;
using System.Linq;
namespace Day21Practice.DataAccess
{
    public class StudentsRepository : IStudentRepository
    {
        StudentdbContext studentdbContext;
        public StudentsRepository(StudentdbContext _studentdbContext)
        {
            studentdbContext = _studentdbContext;
        }
        void IStudentRepository.AddStudentRecord(Students student)
        {
            studentdbContext.Add(student);
            studentdbContext.SaveChanges();
        }
        void IStudentRepository.DeleteStudentRecord(string id)
        {
            var delete = studentdbContext.student.FirstOrDefault(t=>t.id == id);
            studentdbContext.student.Remove(delete);
            studentdbContext.SaveChanges();
        }
        void IStudentRepository.UpdateStudentRecord(Students student)
        {
            studentdbContext.student.Update(student);
            studentdbContext.SaveChanges();
        }
        
        List<Students> IStudentRepository.GetStudentAllRecords()
        {
            return studentdbContext.student.ToList();
        }
        Students IStudentRepository.GetStudentSingleRecord(string id)
        {
            return studentdbContext.student.FirstOrDefault(t => t.id == id);
        }
    }
}