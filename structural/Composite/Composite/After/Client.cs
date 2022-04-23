using Composite.After.Models.Interfaces;

/*
 * Now, using the Compose, we have an interface (ISystemObject) that represent both the files and 
 * folders. This interface allows us to represent our program as a tree structure (as explained below)
 * by centralizing both files and folders to only one abstraction which the program will work with.
 * Inside the concrete implementation of the folder (SystemFolder) is an attribute that 
 * represents a list of ISystemObject; this is the representation of the tree structure, which allows 
 * the folder to hold, at the same place, both files and folders, without needing to know with what it 
 * is working directly. When the GetTotalSize method defined by the interface is called to the 
 * SystemFolder, it delegates all the work to the childrens that, as said before, can be both files or 
 * folders (those children folders will also delegate all the work to its own childrens and so on), 
 * this work could be some heavy business logic that would need to be made by the leaf, wich is the
 * class that don't have any children and thus are the ones whom the work is delegated to (wich in our 
 * example are the files).
 * In our example below, to achieve maximum decoupling we called a factory to give us an already 
 * populated object of ISystemObject and then just called the GetTotalSize method that it have to 
 * implement. Notice how the client doesn't need to know if this object is a file or a folder that 
 * contains a thousand other objects inside it; just calling the method to obtain the size is enough.
 * It's important to mention that we could also define a method to add childrens inside the interface to
 * fully represents to the client that this is a tree structure, but this would violate the interface 
 * segregation principle sice the leafs (files) wouldn't need to implement it.
 */

namespace Composite.After
{
    public static class ClientAfter
    {
        public static void Run()
        {
            Console.WriteLine("== After ==");

            ISystemObject systemObject = Factory.GetPopulatedSystemObject();

            Console.WriteLine("--> Total Size <--");
            Console.WriteLine($"{systemObject.GetTotalSize()} MB");
        }
    }
}
