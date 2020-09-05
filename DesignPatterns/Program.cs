using DesignPatterns.Momento;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private static void MomentoSection()
        {
            var editor = new Editor();
            var history = new History();
            editor.Content = "a";
            history.Push(editor.CreateState());

            editor.Content = "b";
            history.Push(editor.CreateState());

            editor.Content = "c";

            editor.Restore(history.Pop());
            editor.Restore(history.Pop());

            Console.WriteLine(editor.Content);
        }
    }
}
