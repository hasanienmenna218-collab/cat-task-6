using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Product
    {
        public string Name { get; set; } = string.Empty;
        public int Price { get; set; }
    }

    internal class Order
    {
        public string Id { get; set; } = string.Empty;
        public List<Product> products { get; set; } = new();
        public string CustomerEmail { get; set; } = string.Empty;
        public string CustomerNumber { get; set; } = string.Empty;
        public int Total { get; set; }
        public string OrderMassage { get; set; } = string.Empty;
    }
}
