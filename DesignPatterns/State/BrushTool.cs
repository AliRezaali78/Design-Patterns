using System;

namespace DesignPatterns.State
{
    // state B
    public class BrushTool : ITool
    {
        public void MouseUp()
        {
            Console.WriteLine("Brushing");
        }

        public void MouseDown()
        {
            Console.WriteLine("show brush icon");
        }
    }
}