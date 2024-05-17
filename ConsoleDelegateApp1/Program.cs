using System;
using ConsoleDelegateApp1.Services;

namespace ConsoleDelegateApp1
{

    delegate double BinaryNumericOperation(double n1, double n2);
    delegate double BinaryNumericOperation1(double n1);

    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation opSum = CalculationService.Sum;
            BinaryNumericOperation opMax = CalculationService.Max;
            BinaryNumericOperation1 opSquare = CalculationService.Square;

            double result = opSum(a, b);
            Console.WriteLine(result);

            result = opMax(a, b);
            Console.WriteLine(result);

            result = opSquare(a);
            Console.WriteLine(result);
        }
    }
}
