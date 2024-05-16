
namespace ConsoleExtensionMethodApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2024, 05, 16, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}
