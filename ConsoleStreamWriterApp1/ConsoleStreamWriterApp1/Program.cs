using System;
using System.IO;

namespace ConsoleStreamWriterApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath =
                @"D:\Desenvolvedor\Udemy\C#_COMPLETO_Programação_Orientada _a_Objetos_Projetos\temp\file1.txt";
            string targetPath =
                @"D:\Desenvolvedor\Udemy\C#_COMPLETO_Programação_Orientada _a_Objetos_Projetos\temp\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
