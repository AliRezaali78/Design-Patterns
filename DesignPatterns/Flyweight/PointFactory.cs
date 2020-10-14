using System.Collections.Generic;

namespace DesignPatterns.Flyweight
{
    public class PointFactory
    {
        private Dictionary<PointType, PointIcon> _pointIcons = new Dictionary<PointType, PointIcon>();
        public PointIcon GetPointIcon(PointType type)
        {
            if (!_pointIcons.ContainsKey(type))
            {
                var icon = new PointIcon(null, type);
                _pointIcons.Add(type, icon);
            }

            return _pointIcons[type];
        }
    }
}