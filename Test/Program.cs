namespace Test;

internal static class Program
{
    private static void Main(string[] args)
    {
        var simpleTest = new Test(new LoadFromInternalMemory(), new ConsoleOutput(), new ConsoleInputReciever());
        
    }
}