using System.Collections.Generic;

namespace DesignPatterns.Adapter.Example
{
    public class EmailClient
    {
        public List<IEmailProvider> EmailProviders { get; set; } = new List<IEmailProvider>();

        public void DownloadEmails()
        {
            foreach (var emailProvider in EmailProviders)
                emailProvider.DownloadEmails();
        }
    }
}