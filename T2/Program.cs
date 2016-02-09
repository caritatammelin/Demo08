using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            products.Add(new Product { Name = "Bread", Price = 2.50 });
            products.Add(new Product { Name = "Butter", Price = 2.90 });
            products.Add(new Product { Name = "Cheese", Price = 3.40 });
            products.Add(new Product { Name = "Milk", Price = 2.20 });
            products.Add(new Product { Name = "Juice", Price = 4.90 });

            Console.WriteLine("Products in collection:\n");

            foreach (Product product in products)
            {
                Console.WriteLine("-product: {0} {1}e", product.Name, product.Price);
            }
        }
    }
}
