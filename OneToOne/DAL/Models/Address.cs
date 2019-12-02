using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOne.DAL.Models
{
    class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public int BuildingNumber { get; set; }
        public virtual Person Person { get; set; }        
    }
}
