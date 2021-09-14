using Microsoft.EntityFrameworkCore;
using PatientRepository.Models;

namespace PatientRepository.DataAccess
{
    public class PatientdbContext : DbContext
    {
        public PatientdbContext(DbContextOptions dbContextOptions):base(dbContextOptions)
        {
            
        }
        public DbSet<Patient> patients{get; set;} // for local manipulation
    }
}