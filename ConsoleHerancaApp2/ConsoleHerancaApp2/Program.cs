using System;
using System.Globalization;
using System.Collections.Generic;
using ConsoleHerancaApp2.Entities;

namespace ConsoleHerancaApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported(c / u / i) ? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'c')
                {
                    products.Add(new Product(name, price));
                }
                else if (ch == 'i') {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    ImportedProduct imp = new ImportedProduct(name, price, customsFee);
                    imp.TotalPrice();
                    products.Add(imp);
                }
                else 
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    string manufactureDate = Console.ReadLine();
                    UsedProduct used = new UsedProduct(name, price, DateTime.Parse(manufactureDate));
                    products.Add(used);
                }
            }

            Console.WriteLine("PRICE TAGS: ");

            foreach (Product product in products)
            {
                Console.WriteLine(product.priceTag());
            }
        }
    }
}
