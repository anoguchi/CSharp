// Capture a user's age from the console and then identify how old they will be in 25 years, as well as how old they were 25 years ago. Print that information to the console in natural language.

Console.Write("How old are you? ");
string? ageText = Console.ReadLine();
int.TryParse(ageText, out int age);
int yearsAgo = 25;

Console.WriteLine($"You would be {age + yearsAgo} in {yearsAgo} years and {yearsAgo} years ago, you were {age - yearsAgo}.");