
namespace DesignPatterns.Memento
{
    // Originator
    public class Editor
    {   
        public string Content { get; set; }
        public string Title { get; set; }

        public EditorState CreateState()
        {
            return new EditorState(Content, Title);
        }

        public void Restore(EditorState state)
        {
            Content = state.Content;
            Title = state.Title;
        }
    }
}
