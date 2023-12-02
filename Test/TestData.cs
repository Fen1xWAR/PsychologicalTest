using System.Text.Json.Serialization;

namespace Test;

public class TestData
{
    public string TestName { get; set; }
    public List<Scale> ScaleList { get; set; }
    
    public List<Question> Questions { get; set; }
    
    public Dictionary<string, int> AnswersVariant { get; set; }

    [JsonConstructor]
    public TestData(string testName, List<Scale> scaleList, List<Question> questions, Dictionary<string, int> answersVariant)
    {
        TestName = testName;
        ScaleList = scaleList;
        Questions = questions;
        AnswersVariant = answersVariant;
    }
}