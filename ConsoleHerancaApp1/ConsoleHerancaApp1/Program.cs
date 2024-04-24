using ConsoleHerancaApp1.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleHerancaApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Alex", 500.00);
            Account acc2 = new SavingsAccount(1002, "Anna", 500.00, 0.01);

            acc1.WithDraw(10.00);
            acc2.WithDraw(10.00);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}
