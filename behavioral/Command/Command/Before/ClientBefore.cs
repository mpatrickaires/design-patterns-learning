using Command.Before.Buttons;
using Command.Common;

/*
 * Let's imagine the following: we have an app with a GUI, and also a base class that represents a 
 * button. A button can have multiple purposes and have many different behaviors from when it is 
 * clicked. We will be working with a text editor which requires those multiple purposes buttons.
 * To implement it now, the most obvious way is creating subclasses of buttons with each one 
 * implementing the specific behavior we want. This seems good, but come with big problems: we will 
 * need to have too much classes to implement logics that may have repeated code, with all they 
 * inheriting from the base button (and thus being at risk of breaking when it changes), and also
 * needing a group of buttons highly coupled with a GUI component (like the TextEditor in our example).
 * 
 * A good alternative for that would be to have a button class that would dynamically receive its 
 * behavior to be executed when clicked, so let's see how to do that!
 */

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
