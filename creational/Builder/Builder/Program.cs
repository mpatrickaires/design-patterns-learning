using Builder.After.ClassicGof;
using Builder.After.Fluent;
using Builder.After.StepBuilder;
using Builder.Before;

void Separator()
{
    Console.WriteLine();
    Console.WriteLine("--------------------------------------------------------------------");
    Console.WriteLine();
}

ClientBefore.Run();

Separator();

ClientClassicGof.Run();

Separator();

ClientFluent.Run();

Separator();

ClientStepBuilder.Run();