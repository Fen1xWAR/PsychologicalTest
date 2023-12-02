using System.Text.Json;

namespace Test;

public class JsonLoader : ILoadData
{
    private string Path { get; set; }
    public JsonLoader(string path)
    {
        Path = path;
    }

    public TestData LoadData()
    {
        string fileName = Path;
        if (fileName == null) throw new ArgumentNullException(nameof(fileName));
        if (!File.Exists(fileName))
            throw new FileNotFoundException($"Файл {fileName} не найден");

        var jsonString = File.ReadAllText(fileName);
        var s1 = JsonSerializer.Deserialize<TestData>(jsonString);
        // Console.WriteLine(s1.TestName);
        return s1;
    }
}