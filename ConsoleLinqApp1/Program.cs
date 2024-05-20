using System;
using System.Linq;

namespace ConsoleLinqApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Specify the data source
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            // Define the query expression
            var result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            // Execute the Query
            foreach (int x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}
