using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleDictionaryApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    Dictionary<string, int> dict = new Dictionary<string, int>();

                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string candidate = line[0];
                        int votes = int.Parse(line[1]);

                        if (dict.ContainsKey(candidate))
                        {
                            dict[candidate] += votes;
                        } else
                        {
                            dict[candidate] = votes;
                        }
                    }

                    foreach (var item in dict) 
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
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
