using Microsoft.AspNetCore.Mvc;
using Day21Practice.DataAccess;
using System.Collections.Generic;
using Day21Practice.Models;
namespace Day21Practice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        IStudentRepository IstudentRepo;
        public StudentsController(IStudentRepository _studentRepo)
        {
            IstudentRepo = _studentRepo;
        }
        [HttpPost]
        public ActionResult CreateStudent(Students student)
        {
            IstudentRepo.AddStudentRecord(student);
            return Ok("record added");
        }
        [HttpPost("Update")]
        public ActionResult UpdateStudent(Students student)
        {
            if(ModelState.IsValid)
            {
                IstudentRepo.UpdateStudentRecord(student);
                return Ok("record update");
            }
            return BadRequest();
        }
        [HttpDelete("Delete")]
        public ActionResult DeleteStudent(string id)
        {
            if(ModelState.IsValid)
            {
                IstudentRepo.DeleteStudentRecord(id);
                return Ok("record delete");
            }
            return BadRequest();
        }
        [HttpGet]
        public ActionResult GetSingleRecord(string id)
        {
            var get = IstudentRepo.GetStudentSingleRecord(id);
            return Ok(get);
        }
        [HttpGet("list")]
        public IEnumerable<Students> GetStudentAllRecord(string id)
        {
            var gets = IstudentRepo.GetStudentAllRecords();
            return gets ;
        }
    }
}