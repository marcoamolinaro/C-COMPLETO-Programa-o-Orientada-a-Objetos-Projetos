using ConsoleDelegateApp1.Services;

namespace ConsoleDelegateApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            double result = CalculationService.Sum(a, b);
            Console.WriteLine(result);

            result = CalculationService.Max(a, b);
            Console.WriteLine(result);

            result = CalculationService.Square(a, b);
            Console.WriteLine(result);
        }
    }
}
