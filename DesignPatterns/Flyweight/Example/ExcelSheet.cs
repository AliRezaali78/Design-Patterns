using System;

namespace DesignPatterns.Flyweight.Example
{
    public class ExcelSheet
    {
        private readonly FontFactory _fontFactory;
        private static readonly int MAX_ROWS = 3;
        private static readonly int MAX_COLS = 3;

        private readonly string _fontFamily = "Times New Roman";
        private readonly int _fontSize = 12;
        private readonly bool _isBold = false;

        private readonly Cell[,] _cells = new Cell[MAX_ROWS, MAX_COLS];

        public ExcelSheet(FontFactory fontFactory)
        {
            _fontFactory = fontFactory;
            GenerateCells();
        }

        public void SetContent(int row, int col, string content)
        {
            EnsureCellExists(row, col);

            _cells[row, col].Content = content;
        }

        public void SetFontFamily(int row, int col, string fontFamily)
        {
            EnsureCellExists(row, col);

            var cell = _cells[row, col];
            cell.Font = _fontFactory.GetFont(new Font(fontFamily, cell.Font.FontSize, cell.Font.IsBold));
        }

        public void SetIsBold(int row, int col, bool isBold)
        {
            EnsureCellExists(row, col);

            var cell = _cells[row, col];
            cell.Font = _fontFactory.GetFont(new Font(cell.Font.FontFamily, cell.Font.FontSize, isBold));
        }

        private void EnsureCellExists(int row, int col)
        {
            if (row < 0 || row >= MAX_ROWS)
                throw new ArgumentOutOfRangeException();

            if (col < 0 || col >= MAX_COLS)
                throw new ArgumentOutOfRangeException();
        }

        private void GenerateCells()
        {
            for (var row = 0; row < MAX_ROWS; row++)
                for (var col = 0; col < MAX_COLS; col++)
                    _cells[row, col] = new Cell(row, col) { Font = _fontFactory.GetFont(new Font(_fontFamily, _fontSize, _isBold)) };
        }

        public void Render()
        {
            for (var row = 0; row < MAX_ROWS; row++)
                for (var col = 0; col < MAX_COLS; col++)
                    _cells[row, col].Render();
        }
    }
}