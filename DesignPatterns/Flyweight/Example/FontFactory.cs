using System.Collections.Generic;

namespace DesignPatterns.Flyweight.Example
{
    public class FontFactory
    {
        private readonly ISet<Font> _fonts = new HashSet<Font>();

        public Font GetFont(Font font)
        {
            if (!_fonts.Contains(font))
                _fonts.Add(font);

            return font;
        }

    }
}
