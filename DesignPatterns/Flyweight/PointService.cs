using System.Collections.Generic;

namespace DesignPatterns.Flyweight
{
    public class PointService
    {
        private readonly PointFactory _pointFactory;

        public PointService(PointFactory pointFactory)
        {
            _pointFactory = pointFactory;
        }

        public IEnumerable<Point> GetPoints()
        {
            var points = new List<Point>();
            var point = new Point(1, 2, _pointFactory.GetPointIcon(PointType.Hospital));
            var point2 = new Point(1900, 2000, _pointFactory.GetPointIcon(PointType.Hospital));

            points.Add(point);
            points.Add(point2);

            return points;
        }
    }
}