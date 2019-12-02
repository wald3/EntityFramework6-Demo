using OneToOne.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOne.DAL
{
    class DbInitialization
    {
        public static void Initialize(AppContext db)
        {
            if (db.Database.Exists())
                db.Database.Delete();
            db.Database.Create();

            var adr = new Address { Street="Wall", BuildingNumber=3 };
            db.Addresses.Add(adr);
            db.SaveChanges();

            var person = new Person { Name = "Pupa", Surname = "Lupa", Age = 69, Address = adr };
            db.People.Add(person);
            db.SaveChanges();
        }
    }
}
