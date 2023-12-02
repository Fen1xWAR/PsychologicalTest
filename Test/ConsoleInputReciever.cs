namespace Test;

public class ConsoleInputReciever : IReciever
{
    public string? GetData()
    {
        // var input = " ";
        // var validInput = false; 
        // while (!validInput)
        // {
        //     input = Console.ReadLine();
        //
        //     if (!string.IsNullOrEmpty(input))
        //     {
        //         validInput = true;
        //     }
        // }
        //
        // return input;

        return Console.ReadLine();
    }
}