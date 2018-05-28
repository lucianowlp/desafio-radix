using Radix.Gateway.Domain.Repository;
using Radix.Gateway.Resource;

namespace Radix.Gateway.Domain.Validations
{
    public class RegisterNewUserValidation : ValidationService<User>
    {
        IUserRepository userRepository;

        public RegisterNewUserValidation(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public override void Validate(User entity)
        {
            if (userExists(entity))
            {
                AddNotification(UserResource.UserExist, EnumTypes.NotificationType.Error);
            }
        }

        private bool userExists(User entity)
        {
            return userRepository.FindByEmail(entity.Email) != null;

        }
    }
}
