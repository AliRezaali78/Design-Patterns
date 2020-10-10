using System;

namespace DesignPatterns.Composite
{
    public class Shape : IComponent
    {
        public void Render()
        {
            Console.WriteLine("Shape Rendered");
        }

        public void Resize()
        {
            Console.WriteLine("Shape Resized");
        }
    }
}
