using DesignPatterns.Adapter;
using DesignPatterns.Adapter.ThirdPartyLibraries;
using DesignPatterns.Bridge;
using DesignPatterns.ChainOfResponsibilty;
using DesignPatterns.Command;
using DesignPatterns.Command.Composite;
using DesignPatterns.Command.UndoableCommand;
using DesignPatterns.Composite;
using DesignPatterns.Decorator;
using DesignPatterns.Facade;
using DesignPatterns.Flyweight;
using DesignPatterns.Mediator;
using DesignPatterns.Memento;
using DesignPatterns.Observer;
using DesignPatterns.Proxy;
using DesignPatterns.State;
using DesignPatterns.Strategy;
using DesignPatterns.Template_Method_Pattern;
using DesignPatterns.Visitor;
using System;
using Button = DesignPatterns.Command.Button;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        private static void ProxySection()
        {
            var library = new Library();
            var books = new[] { "a", "b", "c" };

            foreach (var book in books)
                library.AddEbook(new LoggingEbookProxy(book));

            library.OpenBook("a");
            library.OpenBook("b");
            library.OpenBook("b");
        }

        private static void BridgeSection()
        {
            var remoteController = new RemoteController(new SamsungTV());
            remoteController.TurnOn();

            var advancedRemoteController = new AdvancedRemoteController(new SamsungTV());
            advancedRemoteController.TurnOn();
            advancedRemoteController.SetChanel(1);
        }

        private static void FlyWeightSection()
        {
            var pointService = new PointService(new PointFactory());
            foreach (var point in pointService.GetPoints())
                point.Draw();


            // Example 2
            // var sheet = new ExcelSheet(new FontFactory());
            // sheet.SetFontFamily(0, 0, "Hello");
            // sheet.SetIsBold(0,0,true);
            // sheet.SetIsBold(1,0, true);
            // sheet.SetIsBold(1,1, true);
            // sheet.SetFontFamily(1,1,"Hello");
            // sheet.Render();

        }

        private static void FacadeSection()
        {
            var notificationService = new NotificationService();
            notificationService.Send("Hello Facade Pattern", "Facade");
        }

        private static void DecoratorSection()
        {
            var stream = new CompressedStream(new EncryptedStream(new CloudStream()));
            stream.Write("1234-1234-1234-1234");
        }

        private static void AdapterSection()
        {
            var image = new Image();
            var imageViewer = new ImageViewer(image);
            imageViewer.ApplyFilter(new AwesomeFilter());
            imageViewer.ApplyFilter(new BlackAndWhiteFilter(new BlackAndWhite()));
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

        private static void VisitorSection()
        {
            var htmlDocument = new HtmlDocument();
            htmlDocument.AddNode(new AnchorNode());
            htmlDocument.AddNode(new HeadingNode());
            htmlDocument.Execute(new HighlightOperation());
            htmlDocument.Execute(new BoldOperation());

            var anchor = new AnchorNode();
            anchor.Execute(new HighlightOperation());
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
