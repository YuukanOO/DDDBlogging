using System;

namespace DDDBlogging.Access
{
    public class UserDescriptor
    {
        public Guid UserIdentity { get; private set; }
        public string Username { get; private set; }

        internal UserDescriptor(User user)
        {
            UserIdentity = user.Identity;
            Username =user.Username;
        }
    }
}
