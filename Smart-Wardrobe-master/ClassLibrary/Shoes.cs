using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Shoes
    {
        public int ID { get; set; }
        public List<Cloth> Clothes{ get; set; }
        public string Name { get; set; }
        public int Size { get; set; }
        public string Condition { get; set; }
    }
}
