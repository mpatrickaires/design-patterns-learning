using AbstractFactory.After.AbstractFactory;
using AbstractFactory.Before;

static void Separate()
{
    Console.WriteLine("------------------------------------------------------------------------------");
    Console.WriteLine();
}


ClientBefore.Run();

Separate();

ClientAbstractFactory.Run();