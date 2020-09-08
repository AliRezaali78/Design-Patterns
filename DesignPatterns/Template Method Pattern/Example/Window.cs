using System;

namespace DesignPatterns.Template_Method_Pattern.Example
{
    public abstract class Window
    {
        public void Close()
        {
            OnClosing();

            Console.WriteLine("Closed...");

            OnClosed();
        }

        protected abstract void OnClosing();

        protected abstract void OnClosed();
    }

    public class ChatWindow : Window
    {
        protected override void OnClosing()
        {
            Console.WriteLine("Before Closing ...");
        }

        protected override void OnClosed()
        {
            Console.WriteLine("After Closing");
        }
    }

}
