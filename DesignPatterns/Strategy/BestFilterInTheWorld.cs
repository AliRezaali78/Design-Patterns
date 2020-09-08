using System;

namespace DesignPatterns.Strategy
{
    public class BestFilterInTheWorld : IFilter
    {
        public void ApplyFilter(string imagePath)
        {
            Console.WriteLine("Apply Best Filter IN The World");
        }
    }
}