// String to something else

Console.Write("What is your age? ");
string? ageText = Console.ReadLine();

// Console.WriteLine(ageText + 15); Bad code
// int age = int.Parse(ageText);
bool isValidInt = int.TryParse(ageText, out int age);

Console.WriteLine($"This is valid: {isValidInt}. The number was {age}");
Console.WriteLine(age + 15);

double testDouble = age;
decimal testDecimal = (decimal)testDouble; // casting