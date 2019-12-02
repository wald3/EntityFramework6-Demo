using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace UserDb
{
    class dbContext : DbContext
    {
        public dbContext() : base("UserDb")
        { }
        public DbSet<User> Users { get; set; }
    }
}
