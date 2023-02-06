using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalc
{
    public sealed class Triangle : IShape
    {
        public double EdgeA { get; init; }
        public double EdgeB { get; init; }
        public double EdgeC { get; init; }
        public double[] AllEdges { get; init; }
        public double Perimeter { get; init; }
        public bool IsRectangular { get; init; }

        public Triangle(double edgeA, double edgeB, double edgeC) 
        {
            if (!isExistingTriangle())
            {
                throw new ArgumentException("Треугольника с такими сторонами быть не может.");
            }
            EdgeA = edgeA;
            EdgeB = edgeB;
            EdgeC = edgeC;

            AllEdges = new[] { edgeA, edgeB, edgeC}.Order().ToArray();
            Perimeter = edgeA + edgeB + edgeC;
            IsRectangular = isRectangular();


            bool isExistingTriangle()
            {
                if (edgeA <= 0 || edgeB <= 0 || edgeC <= 0)
                    return false;
                //Треугольник существует только тогда, когда сумма двух его сторон больше третьей.
                if (edgeA + edgeB >= edgeC)
                {
                    if (edgeA + edgeC >= edgeB)
                    {
                        if (edgeB + edgeC >= edgeA)
                        {
                            return true;
                        }
                    }
                }
                return false;
            }

            bool isRectangular()
            {
                if (Math.Pow(AllEdges[0], 2) == Math.Pow(AllEdges[1], 2) + Math.Pow(AllEdges[2], 2))
                {
                    return true;
                }
                return false;
            }
        }

        public double GetArea()
        {
            if (IsRectangular)
            {
                return AllEdges[1] * AllEdges[2] * 0.5d;
            }

            double halfPerimter = Perimeter / 2d;
            return Math.Sqrt(
                halfPerimter 
                * (halfPerimter - AllEdges[0])
                * (halfPerimter - AllEdges[1]) 
                * (halfPerimter - AllEdges[2]));
        }
    }
}
