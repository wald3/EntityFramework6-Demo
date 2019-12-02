using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDb.DAL.Models
{
    class Admin : User
    {
        public virtual Shop Shop { get; set; }
    }
}
