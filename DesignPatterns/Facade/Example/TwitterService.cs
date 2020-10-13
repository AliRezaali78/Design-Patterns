using System.Collections.Generic;

namespace DesignPatterns.Facade.Example
{
    public class TwitterService
    {
        private readonly string _appKey;
        private readonly string _secret;

        public TwitterService(string appKey, string secret)
        {
            _appKey = appKey;
            _secret = secret;
        }

        public List<Tweet> GetRecentTweets()
        {
            var accessToken = GetAccessToken();

            var client = new TwitterClient();
            return client.GetRecentTweets(accessToken);
        }

        private string GetAccessToken()
        {
            var oAuth = new OAuth();
            var requestToken = oAuth.RequestToken(_appKey, _secret);
            var accessToken = oAuth.GetAccessToken(requestToken);
            return accessToken;
        }
    }
}