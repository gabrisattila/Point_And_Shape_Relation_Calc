using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_And_Shape_Relation_Calc.ReadPolygon.Polygon
{
    public class Polygon
    {
        private List<Point> points;

        private List<Border> borders;

        public List<Point> Points { get { return points; } set { points = value; } }

        public List<Border> Borders { get { return borders; } private set { borders = value; } }


        public Polygon(List<Point> points)
        {
            Points = points;
            generateBorders();
        }


        private void generateBorders()
        {
            borders = new List<Border>();

            for (int i = 1; i < points.Count; i++)
            {
                borders.Add(new Border(points[i - 1], points[i]));
            }
        }
    }
}
