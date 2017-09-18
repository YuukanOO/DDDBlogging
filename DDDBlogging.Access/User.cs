using System;

namespace DDDBlogging.Access
{
    public class User
    {
        public Guid Identity { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }

        public User(IPasswordHasher hasher, string username, string password)
        {
            Identity = Guid.NewGuid();

            Rename(username);
            UpdatePassword(hasher, password);
        }

        public void Rename(string newUsername)
        {
            if (string.IsNullOrEmpty(newUsername))
            {
                throw new ArgumentException("Le nom d'utilisateur est requis", nameof(newUsername));
            }

            Username = newUsername;
        }

        public void UpdatePassword(IPasswordHasher hasher, string newPassword)
        {
            if (string.IsNullOrEmpty(newPassword))
            {
                throw new ArgumentException("Le mot de passe est requis", nameof(newPassword));
            }

            Password = hasher.Hash(newPassword);
        }
    }
}
