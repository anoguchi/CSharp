// Set is a group of something (Arrays, Dictionaries and Lists)
// Do loop run the code at least once and While loop runs de code 0 or more times

bool isValidAge;
int age;

do
{
    Console.Write("What is your age? ");
    string ageText = Console.ReadLine();

    isValidAge = int.TryParse(ageText, out age);

    if (isValidAge == false)
    {
        Console.WriteLine("That was an invalid age.");
    }

} while (isValidAge == false);

Console.WriteLine($"Your age is {age}");

int testNumber = 0;

do
{
    Console.WriteLine(testNumber);
    testNumber++;

} while (testNumber <= 10);



