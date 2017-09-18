using System;

namespace DDDBlogging.Access
{
    public interface IUserRepository
    {
        void Add(User user);
        void Delete(User user);
        User GetForIdentity(Guid identity);
        User[] GetAll();
    }
}
