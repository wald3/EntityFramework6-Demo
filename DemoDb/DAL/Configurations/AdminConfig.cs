using DemoDb.DAL.Models;
using System.Data.Entity.ModelConfiguration;

namespace DemoDb.DAL.Configurations
{
    class AdminConfig : EntityTypeConfiguration<Admin>
    {
        public AdminConfig()
        {
            this.HasRequired(a => a.Address);
        }
    }
}
