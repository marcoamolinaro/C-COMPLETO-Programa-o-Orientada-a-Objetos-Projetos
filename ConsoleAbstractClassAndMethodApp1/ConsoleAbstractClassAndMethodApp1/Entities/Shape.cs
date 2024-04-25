using System;
using ConsoleAbstractClassAndMethodApp1.Entities.Enums;

namespace ConsoleAbstractClassAndMethodApp1.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }
        public Shape()
        {
        }
        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
