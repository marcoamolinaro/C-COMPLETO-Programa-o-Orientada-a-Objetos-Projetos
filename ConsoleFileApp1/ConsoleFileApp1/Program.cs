using System;
using System.IO;

namespace ConsoleFileApp1
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
                FileInfo fileInfo = new FileInfo(sourcePath);

                fileInfo.CopyTo(targetPath);

                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }

            }
            catch (IOException ioe) { 
                Console.WriteLine("An error occurred");
                Console.WriteLine(ioe.Message);
            }
        }
    }
}
