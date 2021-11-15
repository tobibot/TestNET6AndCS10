using BenchmarkDotNet.Running;
using Types;

WriteLine("Hello, World!");

PersonStruct p = new ("Nathan", "Heying");

Console.WriteLine($"Hello {p.FirstName} {p.LastName}");

MyMethod("before declaration");

void MyMethod(string callPos) 
{
    Console.WriteLine($"Hi from {callPos}");
}

MyMethod("after declaration");

var results = BenchmarkRunner.Run<TpyesBenchmark>();