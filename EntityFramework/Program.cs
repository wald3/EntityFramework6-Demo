using UserDb.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDb
{
    class Program
    {

        public static void dbInitialization()
        {
            using (var db = new dbContext())
            {
                DbInitialization.dbInitialize(db);
            }
        }

        public static void viewTable()
        {
            using (var db = new dbContext())
            {
                Console.WriteLine("Users: ");
                foreach (var u in db.Users)
                {
                    Console.WriteLine($"\tId: {u.Id}, Name: {u.Name}, Age: {u.Age}");
                }
            }
        }

        static void Main(string[] args)
        {
            dbInitialization();
            viewTable();

            Console.WriteLine("\n\n\nPress any key...");
            Console.ReadKey();
        }
    }
}
