using ConsoleAbstractClassAndMethodApp1.Entities.Enums;

namespace ConsoleAbstractClassAndMethodApp1.Entities
{
    class Rectangle : Shape
    {

        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double hight, Color color) : base(color)
        {
            Width = width;
            Height = hight;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
