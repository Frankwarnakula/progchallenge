using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge
{

    public class Point
    {
        public int X;   
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

    }
    public class Triangle
    {
        public Point PointA;
        public Point PointB;
        public Point PointC;
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(Point pointA, Point pointB, Point pointC)
        {
            PointA = pointA;
            PointB = pointB;
            PointC = pointC;

            sideA = Math.Sqrt(Math.Pow(pointA.Y - pointB.Y, 2) + Math.Pow(pointA.X - pointB.X, 2));
            sideB = Math.Sqrt(Math.Pow(pointA.Y - pointC.Y, 2) + Math.Pow(pointA.X - pointC.X, 2));
            sideC = Math.Sqrt(Math.Pow(pointB.Y - pointC.Y, 2) + Math.Pow(pointB.X - pointC.X, 2));
        }

        private bool IsValid()
        {
            if (PointA.X == PointB.X)
            {
                return false;
            }
            if (PointA.X == PointC.X)
            {
                return false;
            }
            if (PointA.Y == PointC.Y)
            {
                return false;
            }
            if (PointA.Y == PointB.Y)
            {
                return false;
            }
            return true;
        }



        public double AreaOfTriangle()
        {
            double semiPerimeter = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
        }

        public bool IsPointInside(Point pointZ)
        {
            double areaOfPointABZ = Math.Round(new Triangle(PointA, PointB, pointZ).AreaOfTriangle(), 2);
            double areaOfPointACZ = Math.Round(new Triangle(PointA, PointC, pointZ).AreaOfTriangle(), 2);
            double areaOfPointBCZ = Math.Round(new Triangle(PointB, PointC, pointZ).AreaOfTriangle(), 2);
            double areaOfPointABC = Math.Round(new Triangle(PointA, PointB, PointC).AreaOfTriangle(), 2);

            return (areaOfPointABC == areaOfPointABZ + areaOfPointACZ +  areaOfPointBCZ);
        }

    }
}
