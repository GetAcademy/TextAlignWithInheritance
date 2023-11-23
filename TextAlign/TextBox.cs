namespace TextAlign
{
    internal class TextBox
    {
        private readonly Stack<string> _words;

        public TextBox(string text)
        {
            var wordsReversed = text.Split(' ').Reverse();
            _words = new Stack<string>(wordsReversed);
        }

        public void Show(int startX, int startY, int width, int height)
        {
            WriteBorder(startX, startY, width, height);
            var x = startX + 2;
            var y = startY + 1;
            var maxY = startY + height - 1;

            while (true)
            {
                var nextLineWords = GetNextLine(width - 4);
                var line = string.Join(' ', nextLineWords);
                ShowLine(line, x, y, width);
                y++;
                if (y > maxY) break;
            }
        }

        protected virtual void ShowLine(string line, int x, int y, int width)
        {
            Write(line, x, y);
        }

        protected static void WriteBorder(int startX, int startY, int width, int height)
        {
            var borderChar = '\u2588';
            var border = string.Empty.PadLeft(width, borderChar);
            Write(border, startX, startY);
            Write(border, startX, startY + height);
            WriteVertical(borderChar, startX, startY + 1, height - 1);
            WriteVertical(borderChar, startX + width - 1, startY + 1, height - 1);
        }

        protected string[] GetNextLine(int width)
        {
            var words = new List<string>();
            var length = 0;
            while (length + _words.Peek().Length < width)
            {
                var word = _words.Pop();
                words.Add(word);
                length += word.Length + 1;
                if (_words.Count == 0) break;
            }
            return words.ToArray();
        }

        protected static void Write(string text, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(text);
        }

        protected static void WriteVertical(char letter, int x, int y, int count)
        {
            for (var i = 0; i < count; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write(letter);
            }
        }
    }
}
