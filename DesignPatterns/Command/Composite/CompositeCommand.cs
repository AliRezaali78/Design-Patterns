using System.Collections.Generic;

namespace DesignPatterns.Command.Composite
{
    public class CompositeCommand : ICommand
    {
        public List<ICommand> Commands { get; set; } = new List<ICommand>();

        public void AddCommand(ICommand command)
        {
            Commands.Add(command);
        }

        public void Execute()
        {
            foreach (var command in Commands)
                command.Execute();
        }
    }
}
