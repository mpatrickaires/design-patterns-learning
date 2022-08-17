using Proxy.Before.CachingProxy;
using Proxy.Before.ProtectionProxy;
using Proxy.Before.VirtualProxy;

void Separator()
{
    Console.WriteLine();
    Console.WriteLine("--------------------------------------------------------------------");
    Console.WriteLine();
}

ClientBeforeVirtualProxy.Run();

Separator();

ClientBeforeProtectionProxy.Run();

Separator();

ClientBeforeCachingProxy.Run();