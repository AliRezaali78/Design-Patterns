using System;

namespace DesignPatterns.State
{
    // state A
    public class SelectionTool : ITool
    {
        public void MouseUp()
        {
            Console.WriteLine("Drawing selection tool");
        }

        public void MouseDown()
        {
            Console.WriteLine("Showing selection cursor");
        }
    }
}