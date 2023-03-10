using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalc
{
    public sealed class Circle : IShape
    {
        public double Radius { get; init; }
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Радиус должен быть больше 0");
            Radius = radius;
        }
        public double GetArea() => Math.PI * Math.Pow(Radius, 2d);
    }
}
