using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\nDescription: {Description}\nPrice: {Price}";
        }
    }
}
