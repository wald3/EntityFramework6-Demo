using DemoDb.DAL.Context;
using DemoDb.DAL.Models;
using System;
using System.Collections.Generic;
using DemoDb.DAL.InitializationData;

namespace DemoDb.DAL
{
    class DbInitialization
    {
        public static void Initialize(ApplicationContext db)
        {
            if (db.Database.Exists())
                db.Database.Delete();
            db.Database.Create();

            var admin = new Admin 
            {
                Address = new Address
                {
                    CountryCode = "ANONIMIA",
                    BuldingNumber = -1,
                    Street = "ANONIMSAKYA"
                },
                CreateAt = DateTime.UtcNow,
                Name = "Gun Shop Admin B)" 
            };
            db.Admins.Add(admin);
            db.SaveChanges();

            var gunShop = new Shop
            {
                Address = new Address
                {
                    CountryCode = "US",
                    BuldingNumber = 15,
                    Street = "Wall"
                },
                ShopName = "GunShop", 
                Admin = admin   
            };
            db.Shops.Add(gunShop);
            db.SaveChanges();

            var gunShopProducts = new List<Product>
            {
                new Product
                {
                    Name = "Glock",
                    Price = 59.99,
                    Status = Status.InStock,
                    Shop  =  gunShop,
                    About= About.AboutGlock                    
                },
                new Product
                {
                    Name  =  "MP-5",
                    Price = 180.00,
                    Status = Status.RunningLow,
                    Shop  =  gunShop,
                    About= About.AboutMP5
                },
                new Product
                {
                    Name = "AWP",
                    Price = 4_469.99,
                    Status = Status.InStock,
                    Shop  =  gunShop,
                    About= About.AboutAWP
                },
                new Product
                {
                    Name = "Tank",
                    Price = 70_000.00,
                    Status = Status.OutOfStock,
                    Shop  =  gunShop,
                    About= About.AboutTank
                }
            };
            db.Products.AddRange(gunShopProducts);
            db.SaveChanges();

            var customers = new List<Customer>
            {
                new Customer
                {
                    Name="Andrey",
                    CreateAt = DateTime.UtcNow,
                    Address = new Address
                    {
                        CountryCode = "RU",
                        BuldingNumber = 9,
                        Street = "Komsomolskaya"
                    }
                },
                new Customer
                {
                    Name="Mihail",
                    CreateAt = DateTime.UtcNow,
                    Address = new Address
                    {
                        CountryCode = "BEL",
                        BuldingNumber = 35,
                        Street = "Nemiga"
                    }
                },
                new Customer
                {
                    Name="Criss",
                    CreateAt = DateTime.UtcNow,
                    Address = new Address
                    {
                        CountryCode = "CA",
                        BuldingNumber = 2,
                        Street = "Halifax"
                    }
                },
                new Customer
                {
                    Name="Chin-Chong",
                    CreateAt = DateTime.UtcNow,
                    Address = new Address
                    {
                        CountryCode = "CN",
                        BuldingNumber = 14,
                        Street = "Wangfujing"
                    }
                }
            };
            db.Customers.AddRange(customers);
            db.SaveChanges();

            var orders = new List<Order>
            {
                new Order
                {
                    CreateAt = DateTime.UtcNow,
                    Code = Guid.NewGuid().ToString(),
                    Customer = customers[2],
                    Product = gunShopProducts[0],
                    Quentity = 5
                },
                new Order
                {
                    CreateAt = DateTime.UtcNow,
                    Code = Guid.NewGuid().ToString(),
                    Customer = customers[2],
                    Product = gunShopProducts[2],
                    Quentity = 1
                },
                new Order
                {
                    CreateAt = DateTime.UtcNow,
                    Code = Guid.NewGuid().ToString(),
                    Customer = customers[0],
                    Product = gunShopProducts[1],
                    Quentity = 3
                },
                new Order
                {
                    CreateAt = DateTime.UtcNow,
                    Code = Guid.NewGuid().ToString(),
                    Customer = customers[1],
                    Product = gunShopProducts[2],
                    Quentity = 2
                },
                new Order
                {
                    CreateAt = DateTime.UtcNow,
                    Code = Guid.NewGuid().ToString(),
                    Customer = customers[3],
                    Product = gunShopProducts[0],
                    Quentity = 90_000
                }
            };
            db.Orders.AddRange(orders);
            db.SaveChanges();
        }
    }
}
