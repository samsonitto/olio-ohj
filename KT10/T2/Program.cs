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
            products.Add(new Product(){ Name = "Milk", Price = 1.4});
            products.Add(new Product() { Name = "Beer", Price = 2.2 });
            products.Add(new Product() { Name = "Butter", Price = 3.2 });
            products.Add(new Product() { Name = "Cheese", Price = 4.2 });

            Console.WriteLine("All products in collection:");

            foreach(Product item in products)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }

    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }


        public Product()
        {

        }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return string.Format("- product : {0} {1} e", Name, Price);
        }
    }
}
