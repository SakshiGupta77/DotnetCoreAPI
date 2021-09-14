using Day21Practice.Models;
using Microsoft.EntityFrameworkCore;
namespace Day21Practice.DataAccess
{
    public class StudentdbContext : DbContext
    {
        public StudentdbContext(DbContextOptions dbContextOptions): base(dbContextOptions)
        {
            
        }
        public DbSet<Students> student1{get;set;}
    }
}