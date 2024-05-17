using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleDelegateApp1.Services
{
    class CalculationService
    {
        public static void ShowMax(double x, double y)
        {
            double max = (x > y) ? x : y;
            Console.WriteLine(max);
        }

        public static void ShowSum(double x, double y)
        {
            double max = x + y;
            Console.WriteLine(max);
        }
    }
}
