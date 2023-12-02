namespace Test;

public class LoadFromInternalMemory : ILoadData
{
    public TestData LoadData()
    {
        return new TestData("TestTitle", new List<Scale>()
        {
            new Scale("FirstScale", 1, new Dictionary<string, int>()
            {
                {"Ниже среднего", 0},
                {"Выше среднего", 1}
            }),
            new Scale("SecondScale", 2, new Dictionary<string, int>()
            {
                {"Ниже среднего", 1},
                {"Выше среднего", 2}
            })
        }, 
            
            new List<Question>()
        {
            new Question("I am a firstQuestion",  0),
            new Question("I am a firstQuestion 2",  1)
            
        }, 
            new Dictionary<string, int>()
        {
            {"нет", 0},
            {"да", 1}
        });

    }
}