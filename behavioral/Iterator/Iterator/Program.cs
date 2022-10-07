using Iterator.After;
using Iterator.Before;

System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

void Separator()
{
    Console.WriteLine();
    Console.WriteLine("--------------------------------------------------------------------");
    Console.WriteLine();
}

ClientBefore.Run();

Separator();

ClientAfter.Run();