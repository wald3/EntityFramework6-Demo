using System.Collections.Generic;

namespace UserDb.DAL
{
    class DbInitialization
    {
        public static void dbInitialize(dbContext db)
        {
            if (db.Database.Exists())
                db.Database.Delete();
            db.Database.Create();

            var users = new List<User> {
                    new User { Name = "A", Age = 10 },
                    new User { Name = "B", Age = 20 }
                };

            db.Users.AddRange(users);
            db.SaveChanges();
        }
    }
}
