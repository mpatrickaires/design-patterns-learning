/*
 * Now look at that, the Memento Design Pattern came to the rescue! Let's understand what is happening here.
 * As said before, we need to store states of the TextEditor but it has a private field that we would only be able to externally access it by
 * breaking the encapsulation principle (which is a very bad thing to do). So, we need to be able to do that while keeping the internal state
 * of the class safe from the outside world.
 * Well, Memento is the perfect solution for that. The idea is to create a inner class in TextEditor; this inner class will contain the same 
 * fields (or only the ones we want to be able to restore state) of the outer class, and with that the magic happens: the inner class will be 
 * able to manipulate the outer class private fields! (Well, at least in C# it works that way.)
 * So, let's give name to things: the outer class (TextEditor) is the Originator, the inner class (TextEditorMemento) is the Memento, and 
 * there's a third class who is the Caretaker.
 * The main responsability of the Caretaker is to keep within itself a list of instances all the mementos that we may want to recover, while 
 * (generally) being completely ignorant about they states.
 * 
 * Basically, to do the implementation, the originator will have a method to create a memento which will contain its actual state. The memento
 * will be responsible to keep this state and a good advice is to make it immutable, so that it will only receive the state via constructor. 
 * Also, since the memento is the inner class, it will keep a reference to its containing class and will have a method to restore the state it 
 * is keeping, transfering it to the reference it contains. In the middle of all that, we have the caretaker, which (as already said),
 * will keep a collection of the saved states, and also can have a method to restore the state, which will get the last added state 
 * (as in a LIFO collection) and execute its recovery method.
 * A way to make the actual example better is to have an interface representing the memento, which would be the abstraction for the caretaker
 * to work with.
 */

namespace Memento.After
{
    public static class ClientAfter
    {
        public static void Run()
        {
            Console.WriteLine("== After ==");

            var textEditor = new TextEditor();
            var caretaker = new Caretaker();

            textEditor.WriteText("This is my C# example of the Memento Design Pattern.");

            textEditor.WriteText("I will recover this state!");
            var memento = textEditor.Save();
            caretaker.Add(memento);

            textEditor.WriteText("Let's see how to do that.");

            Console.WriteLine("Recovered state:");
            caretaker.Restore();
            Console.WriteLine(textEditor);

            Console.WriteLine("Yay! That was much better, we were able to restore the Internal ID :)");
        }
    }
}
