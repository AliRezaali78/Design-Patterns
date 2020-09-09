using System;

namespace DesignPatterns.Command.Example
{
    public class VideoEditor
    {
        public float Contrast { get; set; } = 0.5f;
        public string Text { get; set; }

        public void RemoveText()
        {
            Text = "";
        }


        public override string ToString()
        {
            return "VideoEditor{" +
                   "contrast=" + Contrast +
                   ", text='" + Text + '\'' +
                   '}';
        }

        public void AddLabel()
        {
            Console.WriteLine("Label " + Text + " Added !");
        }

        public void AddContrast()
        {
            Console.WriteLine("Contrast " + Contrast + " Added !");
        }
    }
}
