using PatientRepository.Models;
using System.Collections.Generic;
namespace PatientRepository.DataAccess
{
    public interface IPatientsRepository
    {
        void AddPatientRecord(Patient patient);  
        void UpdatePatientRecord(Patient patient);  
        void DeletePatientRecord(string id);  
        Patient GetPatientSingleRecord(string id);  
        List<Patient> GetPatientRecords();  
    }
}
