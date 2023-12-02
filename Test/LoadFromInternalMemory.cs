namespace Test;

public class LoadFromInternalMemory : ILoadData
{
    public TestData LoadData()
    {
        var q1 = new Question("I am a firstQuestion", 1, 0); 
        var q2 = new Question("I am a firstQuestion 2", 1, 1);
        var scale1 = new Scale("FirstScale", 1, new Dictionary<string, int>()
        {
            {"Ниже среднего", 0},
            {"Выше среднего", 1}
        });
        var scale2 = new Scale("SecondScale", 2, new Dictionary<string, int>()
        {
            {"Ниже среднего", 1},
            {"Выше среднего", 2}
        });
        return new TestData("TestTitle", new List<Scale>()
        {
            scale1,scale2
        }, 
            
            new List<Question>()
        {
            q1,q2
        }, 
            new Dictionary<string, int>()
        {
            {"нет", 0},
            {"да", 1}
        });

    }
}