using System.Collections.Generic;

namespace DesignPatterns.Memento.Document
{
    public class Document
    {
        public string Content { get; set; }
        public string FontName { get; set; }
        public int FontSize { get; set; }

        public DocumentState CreateState()
        {
            return new DocumentState(Content, FontName, FontSize);
        }

        public void Restore(DocumentState state)
        {
            Content = state.Content;
            FontName = state.FontName;
            FontSize = state.FontSize;
        }
    }

    public class DocumentState
    {
        public string Content { get; }
        public string FontName { get; }
        public int FontSize { get; }

        public DocumentState(string content, string fontName, int fontSize)
        {
            Content = content;
            FontName = fontName;
            FontSize = fontSize;
        }
    }

    public class DocumentHistory
    {
        private Stack<DocumentState> _states = new Stack<DocumentState>();

        public void Push(DocumentState state)
        {
            _states.Push(state);
        }

        public DocumentState Pop()
        {
            return _states.Pop();
        }
    }

}
