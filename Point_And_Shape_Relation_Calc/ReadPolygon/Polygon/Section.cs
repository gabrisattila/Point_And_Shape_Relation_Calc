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
            return (section1.a < section2.a && section1.b > section2.b) ||
                   (section1.a > section2.a && section1.b < section2.b);
        }

    }
}
