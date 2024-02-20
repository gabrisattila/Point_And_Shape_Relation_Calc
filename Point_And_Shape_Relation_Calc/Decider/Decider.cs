using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point_And_Shape_Relation_Calc.ReadPolygon;
using Point_And_Shape_Relation_Calc.ReadPolygon.Polygon;

namespace Point_And_Shape_Relation_Calc.Decider
{
    public class Decider
    {
        private Point point;

        private Polygon polygon;

        public Point Point { get { return point; } set { point = value; } }

        public Polygon Polygon { get { return polygon; } set {  polygon = value; } }

        public Decider()
        {
            Polygon = new PolygonFromXml("polygon.xml").Polygon;
            Point = getPointFromInStream();
        }

        private Point getPointFromInStream()
        {
            Console.WriteLine("Adja meg a kalkulálni kívánt pont x koordinátáját.");
            int x = Console.Read();

            Console.WriteLine("Adja meg a kalkulálni kívánt pont y koordinátáját.");
            int y = Console.Read();

            return new Point(x, y);
        }


        public void decide()
        {
            bool inPolygon = isPointInPolygon(null, null);

            String yesAnswer = "Igen, a megadott pont a poligonon belül található.", 
                    noAnswer = "Nem, a megadott pont nem található a poligonon belül.";

            Console.WriteLine(inPolygon ? yesAnswer : noAnswer);
        }

        private bool isPointInPolygon(Point point, Polygon polygon)
        {
            throw new NotImplementedException();
        }

        private Section drawLineTowardsPolygon(Point point, Polygon polygon)
        {
            throw new NotImplementedException();
        }

        private int countIntersections(Section section, Polygon polygon)
        {
            throw new NotImplementedException();
        }

    }
}
