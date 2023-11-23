namespace TextAlign
{
    internal class TextBoxRight : TextBox
    {
        public TextBoxRight(string text) : base(text)
        {
        }

        protected override void ShowLine(string line, int x, int y, int width)
        {
            var whitespaceCount = width - line.Length;
            Write(line, x + whitespaceCount - 4, y);
        }
    }
}
