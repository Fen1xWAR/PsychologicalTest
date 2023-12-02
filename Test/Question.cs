using System.Text.Json.Serialization;

namespace Test;

[Serializable]
public class Question : IShowable

{
    [JsonConstructor]
    public Question(string questionText, int questionCategory)
    {
        QuestionText = questionText;
        QuestionCategory = questionCategory;
    }

    public string QuestionText { get; set; }

    public int QuestionCategory { get; set; }


    public string DataToShow()
    {
        return QuestionText;
    }
}