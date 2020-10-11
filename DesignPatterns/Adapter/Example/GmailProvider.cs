using DesignPatterns.Adapter.Example.Gmail;

namespace DesignPatterns.Adapter.Example
{
    public class GmailProvider : IEmailProvider
    {
        private readonly GmailClient _client;

        public GmailProvider(GmailClient client)
        {
            _client = client;
        }
        public void DownloadEmails()
        {
            _client.Connect();
            _client.GetEmails();
            _client.Disconnect();
        }
    }
}