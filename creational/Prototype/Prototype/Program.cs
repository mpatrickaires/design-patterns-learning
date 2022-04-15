using Prototype.After.DeepCopy;
using Prototype.After.ShallowCopy;
using Prototype.Before;

void Separator()
{
    Console.WriteLine();
    Console.WriteLine("--------------------------------------------------------------------");
    Console.WriteLine();
}

ClientBefore.Run();

Separator();

ClientShallowCopy.Run();

Separator();

ClientDeepCopy.Run();