using TemplateMethod.After;
using TemplateMethod.Before;

void Separator()
{
    Console.WriteLine();
    Console.WriteLine("--------------------------------------------------------------------");
    Console.WriteLine();
}

ClientBefore.Run();

Separator();

ClientAfter.Run();