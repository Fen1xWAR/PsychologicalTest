
using System.Text.Json.Serialization;

namespace Test;
[Serializable]
public class Scale : IShowable
{
    [JsonConstructor]
    public Scale(string scaleName, int scaleMaxValue, Dictionary<string, int> scaleValuesWithSigns)
    {
        ScaleName = scaleName;
        ScaleMaxValue = scaleMaxValue;
        ScaleValuesWithSigns = scaleValuesWithSigns;
        CurrentValue = 0;
    }

     public string ScaleName { get; set; }
     public int ScaleMaxValue { get; set; }
     public Dictionary<string,int> ScaleValuesWithSigns { get; set; }

  [JsonIgnore]  public int CurrentValue { get; set; }

    private string GetCurrentSingByValue()
    {
        string group = "";
        
        foreach (var kvp in ScaleValuesWithSigns)
        {
            if (CurrentValue <= kvp.Value)
            {
                group = kvp.Key;
                break;
            }
        }

        return group;
    }
    
    public string DataToShow()
    
    {
        return $"{ScaleName}: {(double) CurrentValue/ScaleMaxValue * 100}%  - {GetCurrentSingByValue()}";
    }
}