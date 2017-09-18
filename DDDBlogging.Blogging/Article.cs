using System;

namespace DDDBlogging.Blogging
{
    public class Article
    {
        public Guid Identity { get; private set; }
        public Guid? CategoryIdentity { get; private set; }
        public Guid AuthorIdentity { get; private set; }
        public string Title { get; private set; }
        public string Content { get; private set; }

        public Article(Guid author, string title)
        {
            Identity = Guid.NewGuid();
            AuthorIdentity = author;
            Rename(title);
        }

        public void Rename(string newTitle)
        {
            if (string.IsNullOrEmpty(newTitle))
            {
                throw new ArgumentException("Le titre est requis", nameof(newTitle));
            }

            Title = newTitle;
        }

        public void UpdateContent(string newContent)
        {
            Content = newContent;
        }

        public void AffectToCategory(Guid category)
        {
            CategoryIdentity = category;
        }

        public void NotCategorized()
        {
            CategoryIdentity = null;
        }
    }
}
