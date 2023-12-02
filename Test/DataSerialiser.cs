using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace Test;

public static class DataSerializer
{
   public static void Serialize(object data,string path)
   {
      string fileName = path;
      var options1 = new JsonSerializerOptions
      {
          Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
          WriteIndented = true,
      };
      string jsonString = JsonSerializer.Serialize(data, options1);
      File.WriteAllText(fileName, jsonString);
   }
}