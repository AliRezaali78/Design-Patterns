using System;

namespace DesignPatterns.Visitor
{
    public class HighlightOperation: IOperation
    {
        public void Apply(AnchorNode node)
        {
            Console.WriteLine("highlight anchor");
        }

        public void Apply(HeadingNode node)
        {
            Console.WriteLine("highlight heading");
        }
    }
}