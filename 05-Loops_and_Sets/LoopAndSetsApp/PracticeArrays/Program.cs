// Create an array of 3 names. Ask th user which number to select. When the user giver you a number, return that name. Make sure to check for invalid numbers.

string[] names = new string[3] { "Alberto", "Julia", "Betinho" };

Console.Write($"Select a number between 0 and {names.Length -1}: ");
string numberText = Console.ReadLine();

if (int.TryParse(numberText, out int number) == false)
{
    Console.WriteLine("You did not provide a valid age.");
    return;
}

if (number >= names.Length || number < 0)
{
    Console.WriteLine("Invalid number");
} else
{
    Console.WriteLine($"Name: {names[number]}");
}

