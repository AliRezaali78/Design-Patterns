using System;

namespace DesignPatterns.Command.Composite
{
    public class AddFilterCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Filter Command");
        }
    }
}
