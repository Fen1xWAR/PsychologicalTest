namespace Test;

public class Test
{
    //IO
    public Test(ILoadData dataLoader, IShow shower, IReciever reciever)
    {
       var data = dataLoader.LoadData();
        Shower = shower;
        Reciever = reciever;
        _testName = data.TestName;
        _questionCount = data.Questions.Count;
        _questions = data.Questions;
        _answersVariant = data.AnswersVariant;
        _scales = data.ScaleList;
       
        
        Init();
    }


    //IO
    private IShow Shower { get; set; }
    private IReciever Reciever { get; set; }
    
    
    //Data
    private readonly string _testName;
    private int _questionCount;
    private readonly Dictionary<string,int> _answersVariant;
    private readonly List<Question> _questions;
    private readonly List<Scale> _scales;
    
    //currentState
    private int _currentQuestionIndex = 0;
    private Question CurrentQuestion => _questions[_currentQuestionIndex];

    private void Init()
    {
        Shower.Show(_testName);
        //Для чтения из консоли небольшой костыль (временно)
        Shower.Show("Press y to proceed");
        var recieve = Reciever.GetData();
        if (recieve == "y")
        {
            ProceedCurrentQuestion();
        }
        

        // Shower.Show(CurrentQuestion.DataToShow());
        // var answer =  Reciever.GetAnswer();
        // if (answer == "yes")
        // {
        //     Console.WriteLine("Done");
        //     NextQuestion();
        // }
        // else
        // {
        //     Console.WriteLine("Done");
        // }

    }

    private void ProceedCurrentQuestion()
    {
        var recieve = GetCurrentAnswers();
        _scales[CurrentQuestion.QuestionCategory].CurrentValue += recieve;
        NextQuestion();
        
    }

    private int GetCurrentAnswers()
    {
        while (true)
        {
            Shower.Show(CurrentQuestion.DataToShow());
            var recieve = Reciever.GetData()?.ToLower();
            if (recieve != null && _answersVariant.TryGetValue(recieve, out var value))
            {
                return value;
            }

        }  
    }
    private void NextQuestion()
    {
        
        _currentQuestionIndex++;
        if (_currentQuestionIndex >= _questionCount)
        {
            GetResults();
        }
        else
        {
            ProceedCurrentQuestion(); 
        }
      
        //Block nextButton
        
    }

    private void PreviousQuestion()
    {
        _currentQuestionIndex--;
        if (_currentQuestionIndex >= 0)
        {
            ProceedCurrentQuestion();
        }
        //Block prevButton
    }

    private void GetResults()
    {
        foreach (var scale in _scales)
        {
            Shower.Show(scale.DataToShow());
        }
    }
}