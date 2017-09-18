using System;

namespace DDDBlogging.Blogging
{
    public interface IArticleRepository
    {
        void Add(Article category);
        void Delete(Article category);
        Article GetForIdentity(Guid identity);
        Article[] GetAll();
        Article[] GetForCategory(Guid category);
        Article[] GetForAuthor(Guid author);
    }
}
