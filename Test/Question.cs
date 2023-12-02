namespace Test;

public  class Question : IShowable
{
   private readonly string _questionText;
   public readonly int QuestionCost;
   public readonly int QuestionCategory;

   public Question( string questionText, int questionCost, int questionCategory)
   {
      QuestionCost = questionCost;
      QuestionCategory = questionCategory;
      _questionText = questionText;
   }

   public string DataToShow()
   {
      return  _questionText;
   }
}