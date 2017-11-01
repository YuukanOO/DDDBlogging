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

        public override bool Equals(object obj)
        {
            var asUserDescriptor = obj as UserDescriptor;

            if(asUserDescriptor == null)
            {
                return false;
            }

            return asUserDescriptor.UserIdentity == UserIdentity && asUserDescriptor.Username == Username;
        }

        public override int GetHashCode()
        {
            return new { UserIdentity, Username }.GetHashCode();
        }
    }
}
