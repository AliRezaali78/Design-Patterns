namespace DesignPatterns.Memento
{
    // Memento
    public class EditorState
    {
        public string Content { get;}
        public string Title { get;}

        public EditorState(string content, string title)
        {
            Content = content;
            Title = title;
        }
    }

}