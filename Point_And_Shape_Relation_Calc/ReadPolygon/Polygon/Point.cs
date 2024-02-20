using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;

namespace Point_And_Shape_Relation_Calc.ReadPolygon.Polygon
{
    public class Point
    {
        private int x;

        private int y;

        public int X { get { return x; } set { x = value; } }

        public int Y { get { return y; } set { y = value; } }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static bool operator <(Point p1, Point p2)
        {
            return (p1.X < p2.X && p1.Y < p2.Y);
        }

        public static bool operator >(Point p1, Point p2)
        {
            return (p1.X > p2.X && p1.Y > p2.Y);
        }

        public static Point operator *(Point point, double x)
        {
            return new Point((int)(point.X * x), (int)(point.Y * x));
        }

        public static double operator -(Point point1, Point point2)
        {
            double a = Math.Abs(point1.X - point2.X), b = Math.Abs(point1.Y - point2.Y);
            return Math.Sqrt(a * a + b * b);
        }
    }
}
