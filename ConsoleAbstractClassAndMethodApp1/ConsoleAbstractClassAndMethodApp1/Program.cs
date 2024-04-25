using System.Collections.Generic;
using System.Globalization;

using ConsoleAbstractClassAndMethodApp1.Entities;
using ConsoleAbstractClassAndMethodApp1.Entities.Enums;

namespace ConsoleAbstractClassAndMethodApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or Circle (r/c) ? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red) ? ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (ch == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Hight: ");
                    double hight = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Rectangle(width, hight, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Circle(radius, color));
                }
            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS:");

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
