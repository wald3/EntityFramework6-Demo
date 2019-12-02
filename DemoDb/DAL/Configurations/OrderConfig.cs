using DemoDb.DAL.Models;
using System.Data.Entity.ModelConfiguration;


namespace DemoDb.DAL.Configurations
{
    class OrderConfig : EntityTypeConfiguration<Order>
    {
        public OrderConfig()
        {
            this.HasRequired<Customer>(o => o.Customer)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.CustomerId)
                .WillCascadeOnDelete(false);

            this.HasRequired<Product>(o => o.Product);
        }
    }
}
