using Proxy.After.CachingProxy;
using Proxy.After.ProtectionProxy;
using Proxy.After.VirtualProxy;
using Proxy.Before.CachingProxy;
using Proxy.Before.ProtectionProxy;
using Proxy.Before.VirtualProxy;

void Separator()
{
    Console.WriteLine();
    Console.WriteLine("--------------------------------------------------------------------");
    Console.WriteLine();
}

Console.WriteLine("=================== BEFORE EXAMPLES ===================");

ClientBeforeVirtualProxy.Run();

Separator();

ClientBeforeProtectionProxy.Run();

Separator();

ClientBeforeCachingProxy.Run();

Separator();

Console.WriteLine("=================== AFTER EXAMPLES ===================");

ClientAfterVirtualProxy.Run();

Separator();

ClientAfterProtectionProxy.Run();

Separator();

ClientAfterCachingProxy.Run();