using Adapter.After.ClassAdapter;
using Adapter.After.ObjectAdapter;
using Adapter.Before;

void Separator()
{
    Console.WriteLine();
    Console.WriteLine("--------------------------------------------------------------------");
    Console.WriteLine();
}

ClientBefore.Run();

Separator();

ClientObjectAdapter.Run();

Separator();

ClientClassAdapter.Run();