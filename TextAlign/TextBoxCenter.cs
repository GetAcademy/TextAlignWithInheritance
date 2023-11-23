namespace TextAlign
{
    internal class TextBoxCenter : TextBox
    {
        public TextBoxCenter(string text): base(text)
        {
        }

        protected override void ShowLine(string line, int x, int y, int width)
        {
            var whitespaceCount = (width - line.Length)/2;
            Write(line, x + whitespaceCount - 2, y);
        }
    }
}
