using ConsoleHerancaApp1.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleHerancaApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.00);

            // UPPCASTING
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Alex", 0.0, 200.00);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            // DOWNCASTING
            BusinessAccount acc4 = (BusinessAccount) acc2;
            acc4.Loan(100.00);

            //BusinessAccount acc5 = (BusinessAccount) acc3; -> Erro

            if (acc3 is  BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount;

                acc5.Loan(200.00);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount; // outra forma de fazer casting
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }
        }
    }
}
