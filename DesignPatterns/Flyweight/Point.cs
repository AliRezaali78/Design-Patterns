using System;

namespace DesignPatterns.Flyweight
{
    public class Point
    {
        private readonly int _x;
        private readonly int _y;
        private readonly PointIcon _pointIcon;

        public Point(int x, int y, PointIcon pointIcon)
        {
            _x = x;
            _y = y;
            _pointIcon = pointIcon;
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing {_pointIcon.PointType} at {_x} {_y}");
        }
    }
}
