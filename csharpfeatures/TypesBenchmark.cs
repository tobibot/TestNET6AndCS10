using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using Types;

[SimpleJob(RuntimeMoniker.Net60)]
public class TpyesBenchmark 
{
    
    int ct = 100;

    [Benchmark]
    public void CreatePersonClass()
    {
        var people = new PersonClass[ct];        
        for (int i = 0; i < ct; i++)
        {
            people[i] = new ("peter", "peterson" +1);
        }
    }

    [Benchmark]
    public void CreatePersonStruct()
    {
        var people = new PersonStruct[ct];        
        for (int i = 0; i < ct; i++)
        {
            people[i] = new ("peter", "peterson" +1);
        }        
    }

}