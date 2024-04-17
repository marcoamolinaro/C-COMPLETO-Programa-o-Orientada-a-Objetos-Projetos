using System;
using System.Globalization;

namespace VetoresApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Produto[] produtos = new Produto[n];

            for (int i = 0; i < n; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                produtos[i] = new Produto
                {
                    Nome = nome,
                    Preco = preco
                };
            }

            double soma = 0.0;

            for (int i = 0;i < n;i++)
            {
                soma += produtos[i].Preco;
            }
            
            double avg = soma / n;

            Console.WriteLine("Preço médio = " + avg.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();

        }
    }
}
