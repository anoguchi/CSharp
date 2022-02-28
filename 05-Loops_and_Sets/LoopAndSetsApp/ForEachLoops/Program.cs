// ForEach is better! Use for when you need a counter, when you know how much elements you have in a list.

string data = "Alberto,Julia,Ana,Paula";
List<string> lists = data.Split(',').ToList();


foreach (string list in lists)
{
    Console.WriteLine(list);
}
