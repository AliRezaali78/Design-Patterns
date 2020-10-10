using DesignPatterns.ChainOfResponsibilty;
using DesignPatterns.Command;
using DesignPatterns.Command.Composite;
using DesignPatterns.Command.UndoableCommand;
using DesignPatterns.Composite;
using DesignPatterns.Mediator;
using DesignPatterns.Memento;
using DesignPatterns.Observer;
using DesignPatterns.State;
using DesignPatterns.Strategy;
using DesignPatterns.Template_Method_Pattern;
using System;
using Button = DesignPatterns.Command.Button;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private static void CompositeSection()
        {
            var group1 = new Group();
            group1.Components.Add(new Shape());
            group1.Components.Add(new Shape());

            var group2 = new Group();
            group2.Components.Add(new Shape());
            group2.Components.Add(new Shape());

            var group = new Group();
            @group.Components.Add(group1);
            @group.Components.Add(group2);

            @group.Render();
            @group.Resize();
        }

        private static void ChainOfResponsibilitySection()
        {
            var logger = new Logger(null);
            var compressor = new Compressor(logger);
            var authenticator = new Authenticator(compressor);
            authenticator.Handle(new HttpRequest());
        }

        private static void MediatorPattern()
        {
            var window = new ArticleWindow();
            window.ListBox.Selected = "ABCD";
            window.ListBox.Selected = " ";
        }

        private static void ObserverPatternSection()
        {
            var dataSource = new DataSource();

            var chart = new Chart(dataSource);
            var sheet = new SpreadSheet(dataSource);

            dataSource.Value = 1;
            dataSource.Value = 2;
        }

        private static void UndoableCommandPattern()
        {
            var document = new Document { Content = "Some content" };

            Console.WriteLine("Before");
            Console.WriteLine(document.Content);

            var history = new CommandHistory();
            var boldCommand = new BoldCommand(document, history);
            var button = new Button(boldCommand);
            button.Click();

            Console.WriteLine("After");
            Console.WriteLine(document.Content);


            Console.WriteLine("After Undo");
            var undoCommand = new UndoCommand(history);
            undoCommand.Execute();

            Console.WriteLine(document.Content);
        }

        private static void CommandPatternSection()
        {
            var customerManager = new CustomerManager();
            var button = new Button(new AddCustomerCommand(customerManager));
            button.Click();
        }

        private static void CompositeCommandPatternSection()
        {
            var compositeCommand = new CompositeCommand();
            compositeCommand.Commands.Add(new AddFilterCommand());
            compositeCommand.Commands.Add(new RemoveBlurCommand());
            // compositeCommand.Execute();

            var button = new Button(compositeCommand);
            button.Click();
        }

        private static void TemplateMethodPatternSection()
        {
            var task = new TransferTask();
            task.Execute();
        }

        private static void StrategySection()
        {
            var storage = new ImageStorage(new PngCompressor(), new BestFilterInTheWorld());
            storage.SavePhoto("asas");
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
