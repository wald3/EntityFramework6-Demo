using OneToOne.DAL;
using System.Linq;
using System;

namespace OneToOne
{
    class Program
    {
        static void dbInitialize()
        {
            using (var db = new OneToOne.DAL.AppContext())
            {
                DbInitialization.Initialize(db);
            }
        }

        static void viewTables() 
        {
            using (var db = new OneToOne.DAL.AppContext())
            {
                var ad = db.Addresses.ToList();
                foreach (var p in db.People)
                {
                    var o = p;
                    Console.WriteLine($"Id: {p.Id}, Name: {p.Name} { p.Surname}, Age: {p.Age} "
                        +$"- Billing Address: {p.Address.BuildingNumber} {p.Address.Street} St.");
                }
            }
        }

        static void Main(string[] args)
        {
            dbInitialization();
            viewTables();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
