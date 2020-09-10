using System;

namespace DesignPatterns.ChainOfResponsibilty
{
    public class Authenticator : Handler
    {
        public Authenticator(Handler next) : base(next)
        {
        }

        protected override bool DoHandle(HttpRequest request)
        {
            Console.WriteLine("authenticating");
            return true;
        }
    }
}