using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Context: DbContext
    {
        public Context():base("localsql")
        {

        }
        public DbSet<Cloth> Clothes { get; set; }
       
    }
}
