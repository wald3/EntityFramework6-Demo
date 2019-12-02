using OneToMany.DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace OneToMany.DAL
{
    class DbInitialization
    {
        public static void Initialize(dbContext db)
        {
            if (db.Database.Exists())
                db.Database.Delete();
            db.Database.Create();   

            var g = new Group { GroupNumber = 52493 };
            db.Groups.Add(g);
            db.SaveChanges();
                
            var students = new List<Student>
            {
                    new Student{ Name = "Alexey", Age = 19, Group = g},
                    new Student{ Name = "Vladilav", Age = 20, Group = g},
                    new Student{ Name = "Eroha", Age = 19, Group = g},
                    new Student{ Name = "Valerka(Struchok)", Age = 69, Group = g}
            };
            db.Students.AddRange(students);
            db.SaveChanges();
        }
    }
}
