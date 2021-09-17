using FluentValidation;
namespace UserManagementService.Models
{
    public class UserValidater : AbstractValidator<User>
    {
        public UserValidater()
        {
            RuleFor(t => t.username).NotNull();
            RuleFor(t => t.Age).InclusiveBetween(18, 60);
        }
    }
}