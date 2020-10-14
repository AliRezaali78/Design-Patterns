
namespace DesignPatterns.Flyweight.Example
{
    public class Font
    {
        public string FontFamily { get; }
        public int FontSize { get; }
        public bool IsBold { get; }

        public Font(string fontFamily, int fontSize, bool isBold)
        {
            FontFamily = fontFamily;
            FontSize = fontSize;
            IsBold = isBold;
        }

        public override bool Equals(object? obj)
        {
            var second = obj as Font;
            return FontFamily == second.FontFamily && FontSize == second.FontSize && IsBold == second.IsBold;
        }

        public override int GetHashCode()
        {
            var hashCode = 352033288;
            hashCode = hashCode * -1521134295 + FontFamily.GetHashCode();
            hashCode = hashCode * -1521134295 + FontSize.GetHashCode();
            hashCode = hashCode * -1521134295 + IsBold.GetHashCode();

            return hashCode;
        }
    }
}