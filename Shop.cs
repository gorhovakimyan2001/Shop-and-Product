using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectData
{
    public class Shop
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public virtual List<Product>? products { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
