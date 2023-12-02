namespace Test;

public class ConsoleInputReciever : IReciever
{
    public string? GetData()
    {

        return Console.ReadLine();
    }
}