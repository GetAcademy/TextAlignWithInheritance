using TextAlign;

var text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. ";

var textBoxes = new TextBox[]
{
    new TextBox(text), 
    new TextBoxCenter(text),
    new TextBoxRight(text),
};

var x = 0;
foreach (var textBox in textBoxes)
{
    textBox.Show(x, 0, 30, 10);
    x += 40;
}

Console.SetCursorPosition(0, 12);


