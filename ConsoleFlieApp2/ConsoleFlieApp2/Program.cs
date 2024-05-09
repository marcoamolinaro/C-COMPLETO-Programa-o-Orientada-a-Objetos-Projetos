using System;
using System.IO;

namespace ConsoleFlieApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path =
                @"D:\Desenvolvedor\Udemy\C#_COMPLETO_Programação_Orientada _a_Objetos_Projetos\temp\file1.txt";

            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);

                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch(IOException eie)
            {
                Console.WriteLine("An error occurred:");
                Console.WriteLine(eie.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }

        }
    }
}
