using Visitor.After;
using Visitor.Before;

void Separator()
{
    Console.WriteLine();
    Console.WriteLine("--------------------------------------------------------------------");
    Console.WriteLine();
}

ClientBefore.Run();

Separator();

ClientAfter.Run();