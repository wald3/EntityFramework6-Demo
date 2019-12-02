using System.Collections.Generic;

namespace DemoDb.DAL.Models
{
    public enum Status
    {
        InStock,
        RunningLow,
        OutOfStock
    }

    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Status Status { get; set; } 
        public string About { get; set; }

        public int? ShopId { get; set; }
        public virtual Shop Shop { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
