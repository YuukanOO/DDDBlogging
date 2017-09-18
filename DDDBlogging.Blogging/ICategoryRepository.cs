using System;

namespace DDDBlogging.Blogging
{
    public interface ICategoryRepository
    {
        void Add(Category category);
        void Delete(Category category);
        Category GetForIdentity(Guid identity);
        Category[] GetAll();
    }
}
