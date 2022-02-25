// Create a console application that asks the user for their name. Welcome me (Beto) as professor or anyone else as student. Make sure that "BETO" also gets called professor.

Console.Write("What is your name? ");
string firstName = Console.ReadLine();

if (firstName.ToLower() == "beto" || firstName.ToLower() == "BETO") 
{
    Console.WriteLine($"Welcome professor {firstName}!");
} else
{
    Console.WriteLine("Welcome student!");
}

Console.Write("What is last name? ");
string lastName = Console.ReadLine();

switch (lastName.ToLower())
{
    case "noguchi":
    case "NOGUCHI":
        Console.WriteLine("Hello Master");
        break;
    default:
        Console.WriteLine("Who are you?");
        break;
}



