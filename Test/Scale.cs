namespace Test;

public class Scale : IShowable
{
    public Scale(string scaleName, int scaleMaxValue, Dictionary<string, int> scaleValuesWithSigns)
    {
        ScaleName = scaleName;
        ScaleMaxValue = scaleMaxValue;
        ScaleValuesWithSigns = scaleValuesWithSigns;
        CurrentValue = 0;
    }

    private string ScaleName { get; set; }
    private int ScaleMaxValue { get; set; }
    private Dictionary<string,int> ScaleValuesWithSigns { get; set; }

    public int CurrentValue { get; set; }

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