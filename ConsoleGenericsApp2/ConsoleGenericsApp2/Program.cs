using ConsoleGenericsApp2.Entities;
using ConsoleGenericsApp2.Services;
using System.Globalization;

namespace ConsoleGenericsApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(',');
                string name = vect[0];
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
                products.Add(new Product(name, price));
            }

            CalculationService calculationService = new CalculationService();
            Product max = calculationService.Max(products);

            Console.WriteLine("Max:");
            Console.WriteLine(max);
        }
    }
}
