using DesignPatterns.Memento;
using DesignPatterns.State;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        private static void StatePatternSection()
        {
            var canvas = new Canvas();
            canvas.SelectedTool = new SelectionTool();
            canvas.MouseUp();

            canvas.SelectedTool = new BrushTool();
            canvas.MouseUp();
        }

        private static void MementoSection()
        {
            var editor = new Editor();
            var history = new History();
            editor.Content = "a";
            editor.Title = "d";
            history.Push(editor.CreateState());

            editor.Content = "b";
            editor.Title = "111";
            history.Push(editor.CreateState());

            editor.Content = "c";

            editor.Restore(history.Pop());

            Console.WriteLine(editor.Content + editor.Title);
        }
    }
}
