using System;
using System.Collections.Generic;

namespace DesignPatterns.Facade.Example
{
    public class TwitterClient
    {
        public List<Tweet> GetRecentTweets(string accessToken)
        {
            Console.WriteLine("Getting recent tweets");
            return new List<Tweet>();
        }
    }
}