using System.Collections.Generic;

namespace DemoDb.DAL.Models
{
    class Shop
    {
        public int Id { get; set; }
        public string ShopName { get; set; }
        public virtual Address Address { get; set; }
        public virtual Admin Admin { get; set; }
        public virtual ICollection<Product> Products { get; set; }

        public Shop()
        {
            Products = new List<Product>();
        }
    }
}
