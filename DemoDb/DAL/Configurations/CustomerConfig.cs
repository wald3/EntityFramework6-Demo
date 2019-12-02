using DemoDb.DAL.Models;
using System.Data.Entity.ModelConfiguration;

namespace DemoDb.DAL.Configurations
{
    class CustomerConfig : EntityTypeConfiguration<Customer>
    {
        public CustomerConfig()
        {
            this.HasMany<Order>(c => c.Orders)
                .WithRequired(o => o.Customer)
                .HasForeignKey(o => o.CustomerId)
                .WillCascadeOnDelete(false);
       
            this.HasRequired(c => c.Address);
        }
    }
}
