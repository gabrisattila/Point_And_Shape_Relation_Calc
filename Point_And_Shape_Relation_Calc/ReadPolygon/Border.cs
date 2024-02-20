using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_And_Shape_Relation_Calc.ReadPolygon
{
    public class Border
    {
        private Point a;

        private Point b;

        public Point A { get { return a; } set { a = value; } }

        public Point B { get { return b; } set { b = value; } }

        public Border(Point a, Point b)
        {
            A = a;
            B = b;
        }

        public bool isPointOnThatBorder(Point p)
        {
            return (B.Y - A.Y) * (p.X - A.X) == (B.X - A.X) * (p.Y - A.Y);
        }
    }
}
