using System;
using Day21Practice.Models;
using System.Collections.Generic;
namespace Day21Practice.DataAccess
{
    public interface IStudentRepository
    {
        void AddStudentRecord(Students student);
        void UpdateStudentRecord(Students student);
        void DeleteStudentRecord(string id);
        Students GetStudentSingleRecord(string id);
        List<Students> GetStudentAllRecords();
    }
}