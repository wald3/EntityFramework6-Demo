using OneToMany.DAL.Models;
using System.Data.Entity.ModelConfiguration;

namespace OneToMany.DAL.Configurations
{
    class StudentConfig : EntityTypeConfiguration<Student>
    {
        public StudentConfig()
        {
            this.HasRequired<Group>(s => s.Group)
                .WithMany(g => g.Students)
                .HasForeignKey<int?>(s => s.GroupId);
        }
    }
}
