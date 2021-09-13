using System.Collections.Generic;
using PatientRepository.Models;
using PatientRepository.DataAccess;
using System.Linq;

namespace PatientRepository.DataAccess
{
    public class PatientsRepository : IPatientsRepository
    {
        PatientdbContext patientdbContext;
        public PatientsRepository(PatientdbContext _patientdbContext)
        {
            patientdbContext = _patientdbContext;
        }
        void IPatientsRepository.AddPatientRecord(Patient patient)
        {
            patientdbContext.Add(patient);
            patientdbContext.SaveChanges(); //act as a commit or save record in database
        }

        void IPatientsRepository.DeletePatientRecord(string id)
        {
            var delete = patientdbContext.patients.FirstOrDefault(t => t.id == id);  
            patientdbContext.patients.Remove(delete);  
            patientdbContext.SaveChanges();  
        }

        List<Patient> IPatientsRepository.GetPatientRecords()
        {
            return patientdbContext.patients.ToList();  
        }

        Patient IPatientsRepository.GetPatientSingleRecord(string id)
        {
            return patientdbContext.patients.FirstOrDefault(t => t.id == id); 
        }

        void IPatientsRepository.UpdatePatientRecord(Patient patient)
        {
            patientdbContext.patients.Update(patient);  
            patientdbContext.SaveChanges();  
        }  
    }
}