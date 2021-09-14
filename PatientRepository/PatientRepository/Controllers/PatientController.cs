using Microsoft.AspNetCore.Mvc;
using PatientRepository.Models;
using PatientRepository.DataAccess;
using System.Collections.Generic;
namespace PatientRepository.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PatientController : ControllerBase
    {
        IPatientsRepository IpatientsRepository;
        public PatientController(IPatientsRepository _patientsRepository )
        {
            IpatientsRepository = _patientsRepository;
        }

        [HttpPost]
        public ActionResult createPatient(Patient patient)
        {
            IpatientsRepository.AddPatientRecord(patient);
            return Ok("record is added succefully");
        }
        [HttpPost("Update")]
        public ActionResult Edit(Patient patient)
        {
           if(ModelState.IsValid)
           {
               IpatientsRepository.UpdatePatientRecord(patient);
               return Ok("record update succesfully");
           }
           return BadRequest();
        }

        [HttpDelete("Delete")]
        public ActionResult Delete(string id)
        {
           if(ModelState.IsValid)
           {
               IpatientsRepository.DeletePatientRecord(id);
               return Ok("record delete succesfully");
           }
           return BadRequest();
        }

        [HttpGet]
        public ActionResult GetID(string id)
        {
           var get = IpatientsRepository.GetPatientSingleRecord(id); 
           return Ok(get);
        }

        [HttpGet("list")]  
        public IEnumerable<Patient> Get()  
        {  
            var getall = IpatientsRepository.GetPatientRecords();  
            return getall;
        }  
    }
}