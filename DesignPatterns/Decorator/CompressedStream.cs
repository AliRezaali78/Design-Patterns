namespace DesignPatterns.Decorator
{
    public class CompressedStream : IStream
    {
        private readonly IStream _stream;

        public CompressedStream(IStream stream)
        {
            _stream = stream;
        }
        public void Write(string data)
        {
            data = Compress(data);
            _stream.Write(data);
        }

        private string Compress(string data)
        {
            return data.Substring(0, 5);
        }
    }
}