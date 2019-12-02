using ManyToMany.DAL;
using ManyToMany.DAL.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToMany
{
    class Program
    {
        public static void dbInitialize()
        {
            using (var db = new ApplicationContext())
            {
                DbInitialization.Initialize(db);
            }
        }

        public static void viewTables()
        {
            using (var db = new ApplicationContext())
            {
                Console.WriteLine("Authors List:");
                foreach (var a in db.Authors.Include(a => a.Books))
                {
                    Console.Write($"{a.Name} {a.Surname} has written books:\n");
                    foreach (var b in a.Books)
                    {
                        Console.WriteLine($"\tBook Name: \"{b.Name}\" Price: {b.Price}{b.CurrencySign}");
                    }
                }

                Console.WriteLine("\nBooks List:");
                foreach (var b in db.Books.Include(b=>b.Authors))
                {
                    Console.Write($"Book[{b.Name}] has been written by:\n");
                    foreach (var a in b.Authors)
                    {
                        Console.WriteLine($"\tAuthor: {a.Name} {a.Surname}");
                    }
                }


            }
        }

        static void Main(string[] args)
        {
            dbInitialize();
            viewTables();

            Console.WriteLine("\n\n\npress any key...");
            Console.ReadKey();
        }
    }
}
