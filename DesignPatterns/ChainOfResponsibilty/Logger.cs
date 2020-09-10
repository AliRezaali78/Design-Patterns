using System;

namespace DesignPatterns.ChainOfResponsibilty
{
    public class Logger : Handler
    {
        public Logger(Handler next) : base(next)
        {
        }

        protected override bool DoHandle(HttpRequest request)
        {
            Console.WriteLine("logging...");
            return true;
        }
    }
}