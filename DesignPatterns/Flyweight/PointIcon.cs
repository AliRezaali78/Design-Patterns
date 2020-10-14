namespace DesignPatterns.Flyweight
{
    public class PointIcon
    {
        public PointType PointType { get; private set; }
        public byte[] Icon { get; private set; }

        public PointIcon(byte[] icon, PointType pointType)
        {
            Icon = icon;
            PointType = pointType;
        }
    }
}