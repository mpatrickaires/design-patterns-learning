using FactoryMethod.After.Complex;
using FactoryMethod.After.HalfSimple;
using FactoryMethod.After.Simple;
using FactoryMethod.Before;

static void Separate()
{
    Console.WriteLine("------------------------------------------------------------------------------");
    Console.WriteLine();
}

ClientBefore.Run();

Separate();

ClientComplex.Run();

Separate();

ClientHalfSimple.Run();

Separate();

ClientSimple.Run();

Separate();
