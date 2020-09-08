using System;

namespace DesignPatterns.Strategy
{
    public class PngCompressor : ICompressor
    {
        public void Compress(string imagePath)
        {
            Console.WriteLine("Compressing image in png format");
        }
    }
}