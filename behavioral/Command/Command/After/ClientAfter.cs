using Command.After.Buttons;
using Command.After.Commands;
using Command.After.Commands.Interfaces;
using Command.Common;

/*
 * Now we have a much better implementation, let's understand it.
 * First, we created a single class of button, which will now be concrete and will have a click method
 * implemented
 */

namespace Command.After
{
    public static class ClientAfter
    {
        public static void Run()
        {
            Console.WriteLine("== After ==");

            var textEditor = new TextEditor();

            var allCapsCommand = new AllCapsCommand(textEditor);
            var allLowerCommand = new AllLowerCommand(textEditor);
            var clearCommand = new ClearCommand(textEditor);

            var commandHistory = new Stack<IUndoableCommand>();
            var undoCommand = new UndoCommand(commandHistory);

            var allCapsButton = new BaseButton("All Caps", allCapsCommand);
            var allLowerButton = new BaseButton("All Lower", allLowerCommand);
            var clearButton = new BaseButton("Clear", clearCommand);
            var undoButton = new BaseButton("Undo", undoCommand);

            textEditor.Text = "So Long, and Thanks for All the Fish";
            Console.WriteLine($"Text: {textEditor.Text}\n");

            ClickButton(allCapsButton, textEditor);
            commandHistory.Push(allCapsCommand);

            ClickButton(allLowerButton, textEditor);
            commandHistory.Push(allLowerCommand);

            ClickButton(clearButton, textEditor);
            commandHistory.Push(clearCommand);

            ClickButton(undoButton, textEditor);
        }

        public static void ClickButton(BaseButton button, TextEditor textEditor)
        {
            Console.WriteLine($"Clicking {button.Caption} Button");
            button.Click();
            Console.WriteLine($"Text: {textEditor.Text}\n");
        }
    }
}
