namespace DesignPatterns.Visitor
{
    public interface IHtmlNode
    {
        public void Execute(IOperation operation);
    }
}