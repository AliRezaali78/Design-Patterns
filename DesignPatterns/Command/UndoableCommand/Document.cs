namespace DesignPatterns.Command.UndoableCommand
{
    public class Document
    {
        public string Content { get; set; }

        public void MakeBold()
        {
            Content += " Bolded !";
        }
    }
}
