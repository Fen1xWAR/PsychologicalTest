namespace Test;

public class ToTxtSaver : ISaver
{
    public void Save(string data, string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName, true))
        {
            writer.WriteLine("-------------------------------");
            writer.WriteLine(data);
            
        }
    }
}