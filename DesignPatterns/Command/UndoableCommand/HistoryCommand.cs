using System.Collections.Generic;

namespace DesignPatterns.Command.UndoableCommand
{
    public class HistoryCommand
    {
        private readonly Stack<IUndoableCommand> _commands = new Stack<IUndoableCommand>();

        public int Size => _commands.Count;

        public void Push(IUndoableCommand command)
        {
            _commands.Push(command);
        }

        public IUndoableCommand Pop()
        {
            return _commands.Pop();
        }
    }
}