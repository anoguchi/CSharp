//

bool isComplete = true;

if (isComplete)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}


Console.Write("What is your name?: ");
string? firstName = Console.ReadLine();

if (firstName.ToLower() == "alberto")
{
    Console.WriteLine("Hello my friend");
}
else
{
    Console.WriteLine("Who are you?");
}

Console.WriteLine("End of program!");