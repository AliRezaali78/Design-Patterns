using DesignPatterns.Command.UndoableCommand;

namespace DesignPatterns.Command.Example
{
    public abstract class AbstractUndoableCommand : IUndoableCommand
    {
        protected readonly VideoEditor VideoEditor;
        protected readonly CommandHistory History;

        protected AbstractUndoableCommand(VideoEditor videoEditor, CommandHistory history)
        {
            VideoEditor = videoEditor;
            History = history;
        }

        public void Execute()
        {
            DoExecute();

            History.Push(this);
        }

        public void UnExecute()
        {
            DoUnExecute();
        }

        protected abstract void DoExecute();

        protected abstract void DoUnExecute();

    }
}