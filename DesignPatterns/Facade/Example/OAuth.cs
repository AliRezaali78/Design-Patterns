using System;

namespace DesignPatterns.Facade.Example
{
    public class OAuth
    {
        public string RequestToken(string appKey, string appSecret)
        {
            Console.WriteLine("Getting a request token");
            return "requestToken";
        }

        public string GetAccessToken(string requestToken)
        {
            Console.WriteLine("Getting Access Token");
            return "Access Token";
        }
    }
}
