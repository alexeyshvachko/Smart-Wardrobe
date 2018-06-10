using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Context: DbContext
    {
        public Context():base("localsql")
        {

        }
        public DbSet<Tops> Tops { get; set; }
        public DbSet<Bottoms> Bottoms{ get; set; }
        public DbSet<Shoes> Shoes{ get; set; }
    }
}
