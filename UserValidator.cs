using FluentValidation;

namespace CourseraTest
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.Name).NotEmpty().MinimumLength(3);
            RuleFor(u => u.Email).NotEmpty().EmailAddress();
        }
    }

}
