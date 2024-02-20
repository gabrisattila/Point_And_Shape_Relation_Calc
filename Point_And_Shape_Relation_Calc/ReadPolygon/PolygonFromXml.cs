using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point_And_Shape_Relation_Calc.ReadPolygon.Read;

namespace Point_And_Shape_Relation_Calc.ReadPolygon
{
    public class PolygonFromXml
    {
        private String path;

        private Polygon.Polygon polygon;

        public String Path { get { return path; } set {  path = value; } }

        public Polygon.Polygon Polygon { get { return polygon; } private set { polygon = value; } }

        public PolygonFromXml(String path)
        {
            Path = path;
            createPolygon();
        }

        private void createPolygon()
        {
            ReadXml xmlReader = new ReadXml(Path);
            Polygon = new Polygon.Polygon(xmlReader.Points);
        }
    }
}
