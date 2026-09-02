using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADVC_02
{
    internal class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        public static List<Product> SearchProducts(List<Product> products, Func<Product, bool> factory)
        {
            List<Product> Listproducts = new List<Product>();

            foreach (Product product in products)
            {
                if (factory(product))
                    Listproducts.Add(product);
            }
            return Listproducts;
        }

    }
}
