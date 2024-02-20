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
            return (p1.X < p2.X && p1.Y < p2.Y) || 
                   (p1.X < p2.X && p1.Y == p2.Y) || 
                   (p1.X == p2.X && p1.Y < p2.Y);
        }

        public static bool operator >(Point p1, Point p2)
        {
            return (p1.X > p2.X && p1.Y > p2.Y) ||
                   (p1.X > p2.X && p1.Y == p2.Y) ||
                   (p1.X == p2.X && p1.Y > p2.Y);
        }

        public static bool operator ==(Point p1, Point p2)
        {
            return p1.X == p2.X && p1.Y == p2.Y;
        }

        public static bool operator !=(Point p1, Point p2)
        {
            return p1.X != p2.X && p1.Y != p2.Y;
        }
    }
}
