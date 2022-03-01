// Only work in .NET core and above projects.
// Sometimes you wanna return more than one value from a given method.

using CreatingAMethod;

(string firstName, string lastName) fullName = SampleMethods.GetFullName();
var fullName02 = SampleMethods.GetFullName();
(string firstName03, string lastName03) = SampleMethods.GetFullName();

Console.WriteLine($"First Name: {fullName.firstName}");
Console.WriteLine($"Last Name: {fullName.lastName}");

Console.WriteLine($"First Name: {fullName02.Item1}");
Console.WriteLine($"Last Name: {fullName02.Item2}");

Console.WriteLine($"First Name: {firstName03}");
Console.WriteLine($"Last Name: {lastName03}");

// Discard character _
(string firstName04, _) = SampleMethods.GetFullName();
Console.WriteLine($"First Name: {firstName04}");