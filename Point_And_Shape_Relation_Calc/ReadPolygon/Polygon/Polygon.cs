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

        private double biggestDistanceInsidePolygon;

        public List<Point> Points { get { return points; } set { points = value; } }

        public List<Section> Borders { get { return borders; } private set { borders = value; } }

        public double BiggestDistance
        {
            get { return biggestDistanceInsidePolygon; }
            private set { biggestDistanceInsidePolygon = value;}
        }

        public Polygon(List<Point> points)
        {
            Points = points;
            generateBorders();
            setBiggest();
        }


        private void generateBorders()
        {
            borders = new List<Section>();

            for (int i = 1; i < points.Count; i++)
            {
                borders.Add(new Section(points[i - 1], points[i]));
            }
        }

        private void setBiggest()
        {
            BiggestDistance = 0;

            for (int i = 0; i < Points.Count; i++)
            {
                for (int j = 0; j < Points.Count; j++)
                {
                    if (i != j && Points[i] - Points[j] > BiggestDistance)
                    {
                        BiggestDistance = Points[i] - Points[j];
                    }
                }
            }
        }
    }
}
