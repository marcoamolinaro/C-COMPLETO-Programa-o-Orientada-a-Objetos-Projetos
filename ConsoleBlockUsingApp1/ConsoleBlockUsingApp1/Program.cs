using System;
using System.IO;

namespace ConsoleBlockUsingApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path =
                @"D:\Desenvolvedor\Udemy\C#_COMPLETO_Programação_Orientada _a_Objetos_Projetos\temp\file1.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException ioe)
            {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(ioe.Message);
            }
        }
    }
}
