using OneToMany.DAL.Models;
using System.Data.Entity.ModelConfiguration;

namespace OneToMany.DAL.Configurations
{
    class GroupConfig : EntityTypeConfiguration<Group>
    {
        public GroupConfig()
        {
            this.HasMany<Student>(g => g.Students)
                .WithRequired(s => s.Group)
                .HasForeignKey<int?>(s => s.GroupId);
        }
    }
}
