using System;

namespace DDDBlogging.Blogging
{
    public class Category
    {
        public Guid Identity { get; private set; }
        public string Name { get; private set; }

        public Category(string name)
        {
            Identity = Guid.NewGuid();
            Rename(name);
        }

        public void Rename(string newName)
        {
            if (string.IsNullOrEmpty(newName))
            {
                throw new ArgumentException("Le nom est requis", nameof(newName));
            }

            Name = newName;
        }
    }
}
