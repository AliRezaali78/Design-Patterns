namespace DesignPatterns.Visitor
{
    public interface IOperation
    {
        public void Apply(AnchorNode node);
        public void Apply(HeadingNode node);
    }
}