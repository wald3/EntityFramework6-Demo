using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToMany.DAL.Models
{
    class Group
    {
        public int Id { get; set; }
        public int GroupNumber { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
