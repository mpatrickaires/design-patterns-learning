using Bridge.Before;

void Title(string title)
{
    Console.WriteLine($"==========> {title} <==========");
}

void Separator()
{
    Console.WriteLine();
    Console.WriteLine("--------------------------------------------------------------------");
    Console.WriteLine();
}

Title("Before");
ClientBefore.Run();

Separator();

Title("After");
ClientAfter.Run();