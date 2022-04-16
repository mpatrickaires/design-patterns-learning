using Bridge.Before.Models.Applications;

/*
 * Let's suppose we have two applications and we want to run those applications in two platforms:  
 * Windows and Linux. Without the use of the Bridge, to achieve that we need to create a concrete class 
 * for each variation of the applications we have for each platform we want; this is a bad idea because
 * we have a class explosion (too many concrete classes) and are also creating a boilerplate code. 
 * Also, if in the future we wanted to create a new application or even add support for the macOS 
 * platform, we would need to create even more classes.
 * It's possible to see that this quickly creates a messy structure that can easily go wrong.
 */

namespace Bridge.Before
{
    public static class ClientBefore
    {
        public static void Run()
        {
            var primaryApplicationWindows = new PrimaryApplicationWindows();
            var primaryApplicationLinux = new PrimaryApplicationLinux();

            var secondaryApplicationWindows = new SecondaryApplicationWindows();
            var secondaryApplicationLinux = new SecondaryApplicationLinux();

            Console.WriteLine("--> Primary Application on Windows <--");
            primaryApplicationWindows.Initialize();
            Console.WriteLine();

            Console.WriteLine("--> Primary Application on Linux <--");
            primaryApplicationLinux.Initialize();
            Console.WriteLine();

            Console.WriteLine("--> Secondary Application on Windows <--");
            secondaryApplicationWindows.Initialize();
            Console.WriteLine();

            Console.WriteLine("--> Secondary Application on Linux <--");
            secondaryApplicationLinux.Initialize();
        }
    }
}
