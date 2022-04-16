using Bridge.After.Models.Applications;
using Bridge.After.Models.Platforms;
using Bridge.After.Models.Platforms.Interfaces;

/*
 * Now, by using the Bridge, we defined an interface that represents the Platform, which will ensure
 * that all the platforms created at the app will follow the same structure (for example, in the Before
 * scenario we had the Windows and Linux creating buttons by different methods names, which could create
 * some confusion on code). After that, our applications will now have an association with the object
 * that implements the interface of the platform, receiving that object via DI (Dependency Injection) in
 * the Client code (or any other code that may make use of it).
 * By doing that, we didn't have the need to create a class for each platform variation of the 
 * application, this because the application now works with the interface and will not care about what
 * the implementation is as long as it implements the expected platform interface.
 * Now, if we needed to add support to the macOS, we would just need to create a class for it that
 * implements the application expected interface and then send this object via DI.
 */

namespace Bridge.Before
{
    public static class ClientAfter
    {
        public static void Run()
        {
            IPlatform windows = new Windows();
            IPlatform linux = new Linux();

            var primaryApplicationWindows = new PrimaryApplication(windows);
            var primaryApplicationLinux = new PrimaryApplication(linux);

            var secondaryApplicationWindows = new SecondaryApplication(windows);
            var secondaryApplicationLinux = new SecondaryApplication(linux);

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
