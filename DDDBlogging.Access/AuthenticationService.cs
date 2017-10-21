using System;

namespace DDDBlogging.Access
{
    public class UserNotFound : Exception { }
    public class InvalidPassword : Exception { }

    public static class AuthenticationService
    {
        public static UserDescriptor Authenticate(IUserRepository userRepository, IPasswordHasher hasher, string name, string password)
        {
            var user = userRepository.GetForName(name);

            if (user == null)
            {
                throw new UserNotFound();
            }

            if(!hasher.Match(password, user.Password))
            {
                throw new InvalidPassword();
            }

            return new UserDescriptor(user);
        }
    }
}
