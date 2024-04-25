﻿using System;
using ConsoleAbstractClassAndMethodApp1.Entities.Enums;

namespace ConsoleAbstractClassAndMethodApp1.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}