using System;

namespace DesignPatterns.Flyweight.Example
{
    public class Cell
    {
        private readonly int _row;
        private readonly int _column;
        public string Content { get; set; }

        public Font Font { get; set; }

        public Cell(int row, int column)
        {
            _row = row;
            _column = column;
        }

        public void Render()
        {
            Console.WriteLine($"({_row}, {_column}): {Content} {Font.FontFamily} {Font.IsBold}\n");
        }
    }
}
