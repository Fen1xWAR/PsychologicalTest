using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace Test;

internal static class Program
{
    private static void Main(string[] args)
    {
        var path = Path.Combine("..", "..", "..", "EmotionalTest.json");
        var simpleTest = new Test(new JsonLoader(path), new ConsoleOutput(), new ConsoleInputReciever(),new ToTxtSaver());
        // var loader = new JsonLoader();
        // var data = loader.LoadData();
        // Console.WriteLine(data.TestName);


        DataSerializer.Serialize(new Question("Test",1),"Serialazed.json");


        // string fileName = "C:\\Users\\PC\\RiderProjects\\Test\\Test\\TestData.json";
        // if (fileName == null) throw new ArgumentNullException(nameof(fileName));
        // var jsonString = File.ReadAllText(fileName);
        // var s1 = JsonSerializer.Deserialize<TestData>(jsonString);
        // Console.WriteLine(s1.TestName);
    }
}