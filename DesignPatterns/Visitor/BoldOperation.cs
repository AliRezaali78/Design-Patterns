using System;

namespace DesignPatterns.Visitor
{
    public class BoldOperation : IOperation
    {
        public void Apply(AnchorNode node)
        {
            Console.WriteLine("bold anchor");
        }

        public void Apply(HeadingNode node)
        {
            Console.WriteLine("bold heading");
        }
    }
}