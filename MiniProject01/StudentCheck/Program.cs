// Plan and build a console application that asks a user for their name and their age. If their name is Beto or Alberto, address them as Professor. If the person is under 21, recommend they wait X years to start this class.

Console.Write("What is your name? ");
string firstName = Console.ReadLine();

Console.Write("What is your age? ");
string ageText = Console.ReadLine();

string formattedName;


if (int.TryParse(ageText, out int age))
{
    if (firstName.ToLower() == "Beto" || firstName.ToLower() == "Alberto")
    {
        formattedName = $"Professor {firstName}";
    }
    else
    {
        formattedName = firstName;
    }
    if (age < 21)
    {
        Console.WriteLine($"I recommend you wait {21 - age} years, {formattedName}");
    }
    else
    {
        Console.WriteLine($"Welcome to class {formattedName}");
    }

}
else
{
    Console.WriteLine("You did not provide a valid age.");
}

