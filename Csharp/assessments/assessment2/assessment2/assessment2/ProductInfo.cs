using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment2
{
    class Product
    {
        public int ProductId{ get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        protected Product( int productId, string productName, double price)
        {
            ProductId = productId;
            ProductName= productName;
            Price = price;
        }
        public void Display()
        {
            Console.WriteLine($"Product Id: {ProductId}, Name: {ProductName}, Price:{Price:c}") ;
        }
    }
    class ProductInfo
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            for (int i= 1; i <=3; i++)
            {
                Console.WriteLine($"Enter details for product {i}:");

                Console.WriteLine("Product ID:");
                int productId = int.Parse(Console.ReadLine());

                Console.WriteLine("Product Name:");
                string productName= Console.ReadLine();

                Console.WriteLine("Price:");
                double price = double.Parse(Console.ReadLine());
               
            }
            var sortedProducts = products.OrderBy(p => p.Price).ToList();
            Console.WriteLine("Product sorted by price ");
            foreach (var product in sortedProducts)
            {
                product.Display();
            }
            Console.ReadLine();
        }
    }
}