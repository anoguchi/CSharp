// Ask the user for a comma-separated list of first names (no spaces). Split the string into a string array. Loop throug the array and print "Hello <name>" to the console for each person.


Console.Write("Digit a list of names (with a comma-separated): ");
List<string> list = Console.ReadLine().Split(',').ToList();

for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine($"Hello {list[i]}");
}



