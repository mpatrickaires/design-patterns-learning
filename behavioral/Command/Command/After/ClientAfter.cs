using Command.After.Buttons;
using Command.After.Commands;
using Command.After.Commands.Interfaces;
using Command.Common;

/*
 * Now we have a much better implementation, let's understand it.
 * First, we created a single class of button, which will now be concrete and will have a click method
 * implemented. Now, this click method will not actually do anything, it will only call the method 'Execute' of the interface ICommand; the 
 * concrete implementation of that interface is received externally by inversion of control.
 * The purpose of the command is actually pretty simple: it will be called by an invoker and (in most of the cases) will simple call a wrapped 
 * receiver. It is basically the transformation of a request into an entirely new object.
 * This creates some advantages, such as the creation of an additional layer beteween the invoker and the receiver, the ability to treat the 
 * requests in a sort of lazy evaluation and to queue them in some storage, and also the possibility of serializing this object to keep in a 
 * database or even to send it through a network.
 * Another great point is that this command can also implement a undo method, which will basically revert what was performed by its execution 
 * method, that way we can keep track of what was executed and also undo it at anytime.
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
