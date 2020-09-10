namespace DesignPatterns.ChainOfResponsibilty
{
    public class WebServer
    {
        private Handler _handler;

        public WebServer(Handler handler)
        {
            _handler = handler;
        }

        public void HandleRequest(HttpRequest request)
        {
            _handler.Handle(request);
        }
    }
}
