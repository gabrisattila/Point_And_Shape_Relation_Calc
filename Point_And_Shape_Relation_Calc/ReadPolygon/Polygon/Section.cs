using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_And_Shape_Relation_Calc.ReadPolygon.Polygon
{
    public class Section
    {
        private Point a;

        private Point b;

        public Point A { get { return a; } set { a = value; } }

        public Point B { get { return b; } set { b = value; } }


        public Section(Point a, Point b)
        {
            A = a;
            B = b;
        }

        public static bool isTwoSectionCrossEachOther(Section section1, Section section2)
        {
            return false;
        }



        public bool isPointOnThatBorder(Point p)
        {
            return (B.Y - A.Y) * (p.X - A.X) == (B.X - A.X) * (p.Y - A.Y);
        }
    }
}
