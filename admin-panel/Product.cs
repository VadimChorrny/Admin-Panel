using System;
using System.Collections.Generic;
using System.Text;

namespace admin_panel
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public override string ToString() => $"Name: {Name}" +
            $" Description: {Description}" +
            $" Price: {Price}";
    }
}
