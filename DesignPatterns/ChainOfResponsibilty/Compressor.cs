using System;

namespace DesignPatterns.ChainOfResponsibilty
{
    public class Compressor : Handler
    {
        public Compressor(Handler next) : base(next)
        {
        }

        protected override bool DoHandle(HttpRequest request)
        {
            Console.WriteLine("Compressed");
            return true;
        }
    }
}