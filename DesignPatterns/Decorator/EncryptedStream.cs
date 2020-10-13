namespace DesignPatterns.Decorator
{
    public class EncryptedStream : IStream
    {
        private readonly IStream _stream;

        public EncryptedStream(IStream stream)
        {
            _stream = stream;
        }
        public void Write(string data)
        {
            data = Encrypt(data);
            _stream.Write(data);
        }

        private string Encrypt(string data)
        {
            return "&@^#*@^#@&*>?><><";
        }
    }
}