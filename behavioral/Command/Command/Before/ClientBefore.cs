using Command.Before.Buttons;
using Command.Common;

namespace Command.Before
{
    public static class ClientBefore
    {
        public static void Run()
        {
            Console.WriteLine("== Before ==");

            var textEditor = new TextEditor();

            var allCapsButton = new AllCapsButton("All Caps", textEditor);
            var allLowerButton = new AllLowerButton("All Lower", textEditor);
            var clearButton = new ClearButton("Clear", textEditor);

            textEditor.Text = "So Long, and Thanks for All the Fish";
            Console.WriteLine($"Text: {textEditor.Text}\n");

            ClickButton(allCapsButton, textEditor);
            ClickButton(allLowerButton, textEditor);
            ClickButton(clearButton, textEditor);
        }

        public static void ClickButton(TextEditorButton button, TextEditor textEditor)
        {
            Console.WriteLine($"Clicking {button.Caption} Button");
            button.Click();
            Console.WriteLine($"Text: {textEditor.Text}\n");
        }
    }
}
