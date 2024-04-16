using System.Globalization;


namespace EncapsulamentoApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ContaBancaria conta;

            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre com o valor do depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta =  new ContaBancaria(numero, titular, depositoInicial);
            } else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da Conta");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre o valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            conta.Deposito(quantia);

            Console.WriteLine();
            Console.WriteLine("Dados da Conta atualizados");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre o valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            conta.Saque(quantia);

            Console.WriteLine();
            Console.WriteLine("Dados da Conta atualizados");
            Console.WriteLine(conta);


        }
    }
}
