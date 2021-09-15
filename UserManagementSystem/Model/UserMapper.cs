using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace UserManagementSystem.Model
{
    //Implementing FluentApi for defining the structure or schema for user
    public class UserMapper
    {
        public UserMapper(EntityTypeBuilder<User> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(t => t.id);
            entityTypeBuilder.Property(a => a.name ).IsRequired();
            entityTypeBuilder.Property(a => a.age).IsRequired();
             entityTypeBuilder.Property(a => a.city).IsRequired();


        }
    }
}