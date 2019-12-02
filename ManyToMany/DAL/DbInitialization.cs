using ManyToMany.DAL.Context;
using ManyToMany.DAL.Models;
using System.Collections.Generic;

namespace ManyToMany.DAL
{
    class DbInitialization
    {
        public static void Initialize(ApplicationContext db)
        {
            if (db.Database.Exists())
                db.Database.Delete();
            db.Database.Create();

            var book = new Book { Name = "How Second hates First", Price = 59.99, CurrencySign = "$" };
            db.Books.Add(book);
            db.SaveChanges();

            var authorA = new Author { Name = "First", Surname = "Author"};
            authorA.Books.Add(book);

            var authorB = new Author { Name = "Second", Surname = "Author" };
            authorB.Books.Add(book);

            db.Authors.AddRange(new List<Author>() { authorA, authorB});
            db.SaveChanges();
        }
    }
}
