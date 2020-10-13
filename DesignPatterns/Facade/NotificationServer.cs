using System;

namespace DesignPatterns.Facade
{
    public class NotificationServer
    {
        public Connection Connect(string ipAddress)
        {
            return new Connection();
        }

        public AppToken Authenticate(string appId, string key)
        {
            return new AppToken();
        }

        public void Send(AppToken token, Message message, string target)
        {
            Console.WriteLine("sending message");
        }
    }
}
