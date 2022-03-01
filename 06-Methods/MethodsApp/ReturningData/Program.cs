// 
using CreatingAMethod;
using MethodsParameters;

string name = SampleMethods.GetUsersName();
SampleMethods.SayHi(name);

// best for debugs
double result = MathShortcuts.Add(10, 80);
Console.WriteLine(result);


Console.WriteLine($"The result is {MathShortcuts.Add(10, 100)}");