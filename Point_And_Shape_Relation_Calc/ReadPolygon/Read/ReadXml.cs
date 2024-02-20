using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Point_And_Shape_Relation_Calc.ReadPolygon.Polygon;

namespace Point_And_Shape_Relation_Calc.ReadPolygon.Read
{
    public class ReadXml
    {
        private String path;

        private List<Point> points;

        public String Path { get { return path; } set { path = value; } }

        public List<Point> Points { get { return points; } }

        public ReadXml(String path)
        {
            Path = path;
            fillPointListBase();
        }

        private void fillPointListBase()
        {
            points = new List<Point>();

            XmlDocument doc = new XmlDocument();

            doc.LoadXml(Path);

            XmlNode root = doc.DocumentElement;

            XmlNodeList nodeList = root.SelectNodes("//Point");

            foreach (XmlNode node in nodeList)
            {
                String x = node.SelectSingleNode("X").InnerText;

                String y = node.SelectSingleNode("Y").InnerText;

                int X = Convert.ToInt32(x), Y = Convert.ToInt32(y);

                points.Add(new Point(X, Y));
            }
        }


    }
}
