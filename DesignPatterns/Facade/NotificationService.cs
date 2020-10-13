namespace DesignPatterns.Facade
{
    public class NotificationService
    {
        public void Send(string message, string target)
        {
            var server = new NotificationServer();
            server.Connect("test-server");
            var token = server.Authenticate("appId", "key");
            server.Send(token, new Message(message), target);

        }
    }
}