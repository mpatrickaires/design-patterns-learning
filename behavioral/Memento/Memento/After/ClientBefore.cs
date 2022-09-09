/*
 * Imagine that: we have created a text editor! And what every good text editor must have? Well, besides being able to have text written in it
 * (who could tell?), a very important feature is allowing the user to undo something and go back to previous states of the editor.
 * Well, this seems so easy! Let's just create create instances of this class, copy all the values of the original, add them to a list, and call
 * it a day!
 * Yeah, this is a pretty good solution! But let's difficulty things a little bit, shall we?
 * Our TextEditor class has a private field, which is an internal ID that changes every time a new text is defined through the "WriteText" 
 * method (why? Well, because the business logic says so!). As you probably already imagined, if we wanted to create and store copies of the 
 * text editor now, we wouldn't be able to copy this internal ID due to only the class being able to access it. 
 * 
 * What a difficulty situation, uh? If only there was some design pattern to help us with that...
 */

namespace Memento.After
{
    public static class ClientBefore
    {
        public static void Run()
        {
            Console.WriteLine("== Before ==");

            var textEditor = new TextEditor();

            textEditor.WriteText("This is my C# example of the Memento Design Pattern.");

            textEditor.WriteText("I will recover this state!");
            var textEditorBackup = new TextEditor();
            textEditorBackup.Text = textEditor.Text;
            // Oops, we can't do that! We would need to break the encapsulation principle to achieve this that way...
            //textEditorBackup._internalId = textEditor._internalId;

            textEditor.WriteText("Let's see how to do that!");

            Console.WriteLine("Recovered state:");
            textEditor.Text = textEditorBackup.Text;
            Console.WriteLine(textEditor);

            Console.WriteLine("That didn't go so well, the Internal ID was not recovered :(");
        }
    }
}
