using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneToMany.DAL.Models;

namespace OneToMany
{
    class Program
    {
        static void dbInitialization()
        {
            using (var db = new dbContext())
            {
                OneToMany.DAL.DbInitialization.Initialize(db);
            }
        }

        static void viewGroupsTable()
        {
            using (var db = new dbContext())
            {
                Console.WriteLine("Groups List:");
                foreach (var g in db.Groups.Include(g => g.Students))
                {
                    Console.WriteLine($"Group№: {g.GroupNumber}:");

                    foreach (var s in g.Students)
                    {
                        Console.WriteLine($"\tId: {s.Id}, Name: {s.Name}, Age: {s.Age};");
                    }
                }

                Console.WriteLine("\nStudents List:");
                foreach (var s in db.Students.Include(s=>s.Group))
                {
                    Console.WriteLine($"\tId: {s.Id}, Name: {s.Name}, Age: {s.Age}, Group№: {s.Group.GroupNumber};");

                }


                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            dbInitialization();
            viewGroupsTable();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
