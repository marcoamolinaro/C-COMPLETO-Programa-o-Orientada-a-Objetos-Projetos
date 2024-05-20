﻿using System;
using System.Collections.Generic;
using System.Linq;

using ConsoleFuncApp1.Entities;

namespace ConsoleFuncApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            List<string> result = list.Select(NameUpper).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }

        static string NameUpper(Product product)
        {
            return product.Name.ToUpper();
        }
    }
}
