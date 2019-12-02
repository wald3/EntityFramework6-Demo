using DemoDb.DAL;
using System;
using System.Data.Entity;
using System.Linq;

namespace DemoDb
{
    class Program
    {
        public static void dbInitialize()
        {
            using (var db = new DAL.Context.ApplicationContext())
            {
                DbInitialization.Initialize(db);
            }
        }

        public static void viewCustomersWithOrders()
        {
            using (var db = new DAL.Context.ApplicationContext())
            {
                foreach (var c in db.Customers.Include(c=>c.Orders.Select(o=>o.Product)).Include(c=>c.Address))
                {
                    Console.WriteLine(
                        $"Id: {c.Id}," +
                        $" Name: {c.Name}," +
                        $" Country Code: {c.Address.CountryCode}," +
                        $" Orders Count: {c.Orders.Count}"
                    );
                    if(!c.Orders.Equals(null)) { 
                        foreach (var o in c.Orders)
                        {
                            Console.WriteLine(
                                $"\tId: {o.Id}, " +
                                $"Product: {o.Product.Name}, " +
                                $"Quentity: {o.Quentity}, " +
                                $"Order price: {o.Product.Price * o.Quentity}"
                            );
                        }
                        Console.WriteLine();
                    }
                }
            }
        }

        public static void executeSQL(string sql)
        {
            var db = new DAL.Context.ApplicationContext();
            try
            {
                var result = db.Database.ExecuteSqlCommand(sql);
                Console.WriteLine(result.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine($"\n{e.Message}\n");
            }
        }

        static void Main(string[] args)
        {
            dbInitialize();
            viewCustomersWithOrders();

            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
