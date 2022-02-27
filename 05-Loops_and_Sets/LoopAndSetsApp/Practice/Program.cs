// Create a console application that asks the user for their name. Welcome me (Beto) as professor or anyone else as student. Do this until the user types "exit".

string name;

do
{
    Console.Write("What is yout name? (Type exit to quit application) ");
    name = Console.ReadLine();

    if (name.ToLower() == "beto")
    {
        Console.WriteLine($"Welcome professor {name}!");

    }
    if (name.ToLower() != "exit" && name.ToLower() != "beto")
    {
        Console.WriteLine($"Welcome student {name}");

    }

} while (name.ToLower() != "exit");

