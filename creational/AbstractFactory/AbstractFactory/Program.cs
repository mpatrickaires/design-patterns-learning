using AbstractFactory.After;
using AbstractFactory.Before;

static void Separate()
{
    Console.WriteLine("------------------------------------------------------------------------------");
    Console.WriteLine();
}


ClientBefore.Run();

Separate();

ClientAbstractFactory.Run();