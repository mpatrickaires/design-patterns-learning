using Singleton.After.Monostate;
using Singleton.After.Singleton;
using Singleton.Before;

void Separator()
{
    Console.WriteLine("\n-----------------------------------------------------------------------\n");
}


ClientBefore.Run();

Separator();

ClientSingleton.Run();

Separator();

ClientMonostate.Run();