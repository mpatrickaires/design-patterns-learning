using State.After;
using State.Before;

void Separator()
{
    Console.WriteLine();
    Console.WriteLine("--------------------------------------------------------------------");
    Console.WriteLine();
}

ClientBefore.Run();

Separator();

ClientAfter.Run();