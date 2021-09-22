using UserManagement.Domain;
using Microsoft.EntityFrameworkCore;
namespace UserManagement.Repository
{
    public class ApplicationContexts :DbContext
    {
       
        public ApplicationContexts(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            //linking between user and usermap
            new UserMap(modelBuilder.Entity<User>());
            new UserProfileMap(modelBuilder.Entity<UserProfile>());
        }
    }
}