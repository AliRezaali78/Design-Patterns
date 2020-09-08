namespace DesignPatterns.Command.UndoableCommand
{
    public interface IUndoableCommand : ICommand
    {
        public void UnExecute();
    }
}