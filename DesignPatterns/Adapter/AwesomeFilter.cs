using System;

namespace DesignPatterns.Adapter
{
    public class AwesomeFilter : IFilter
    {
        public void Apply(Image image)
        {
            Console.WriteLine("Applying Awesome filter");
        }
    }
}