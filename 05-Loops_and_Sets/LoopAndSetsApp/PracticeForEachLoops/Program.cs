// Ask the user for their first name. Continue asking for first names until there are no more. Then loop through each name using foreach and tell each person hello on the console.

string name;
List<string> lists = new();

do
{
    Console.Write("What is your first name? (Type exit to quit application) ");
    name = Console.ReadLine();
    
    lists.Add(name);

} while (name.ToLower() != "exit");

lists.RemoveAt(lists.Count - 1);

foreach (string list in lists)
{
    Console.WriteLine($"Hello {list}");
}
