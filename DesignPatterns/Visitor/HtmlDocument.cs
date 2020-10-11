using System.Collections.Generic;

namespace DesignPatterns.Visitor
{
    public class HtmlDocument
    {
        public List<IHtmlNode> HtmlNodes { get; set; } = new List<IHtmlNode>();

        public void AddNode(IHtmlNode node)
        {
            HtmlNodes.Add(node);
        }

        public void Execute(IOperation operation)
        {
            foreach (var node in HtmlNodes)
                node.Execute(operation);
        }
    }
}
