using ConsoleInterfaceApp2.Model.Enums;

namespace ConsoleInterfaceApp2.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
