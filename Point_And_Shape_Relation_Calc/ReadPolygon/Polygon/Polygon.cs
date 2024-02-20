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

        private List<Section> borders;

        private Point maxPoint;

        private Point minPoint;

        public List<Point> Points { get { return points; } set { points = value; } }

        public List<Section> Borders { get { return borders; } private set { borders = value; } }

        public Point Max
        {
            get { return maxPoint; }
            private set { maxPoint = value; }
        }

        public Point Min
        {
            get { return minPoint; }
            private set { minPoint = value; }
        }

        public Polygon(List<Point> points)
        {
            Points = points;
            generateBorders();
        }


        private void setMinMax()
        {
            Point max = points[0], min = points[0];

            foreach (Point point in points)
            {
                if (point < min)
                {
                    min = point;
                }

                if (point > max)
                {
                    max = point;
                }
            }

            Min = min;
            Max = max;
        }


        private void generateBorders()
        {
            borders = new List<Section>();

            for (int i = 1; i < points.Count; i++)
            {
                borders.Add(new Section(points[i - 1], points[i]));
            }
        }
    }
}
