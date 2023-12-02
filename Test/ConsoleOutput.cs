namespace Test;

public class ConsoleOutput : IShow
{
    public void Show(object dataToShow)
    {
       Console.WriteLine(dataToShow);
    }
}