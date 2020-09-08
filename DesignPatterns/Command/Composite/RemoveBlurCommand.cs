using System;

namespace DesignPatterns.Command.Composite
{
    class RemoveBlurCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Removing Blur...");
        }
    }
}
