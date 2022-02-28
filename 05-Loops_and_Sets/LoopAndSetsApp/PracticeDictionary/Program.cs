// Create a Dictionary list of emplooyes IDs and the name that goes with the ID. Fill in a few records. The ask the user for their ID and return their name.

Dictionary<int, string> employees = new Dictionary<int, string>();

employees.Add(1, "Alberto");
employees.Add(2, "Amanda");
employees.Add(3, "Paula");
employees.Add(4, "Paulo");
employees.Add(5, "Diego");
employees.Add(6, "Xand");

Console.Write("Digit the ID: ");
string idText = Console.ReadLine();
// bool validId = int.TryParse(idText, out int id);

if (int.TryParse(idText, out int id) == false)
{
    Console.WriteLine("You did not provide a valid ID.");
    return;
}

if (id > employees.Count)
{
    Console.WriteLine("Not found");
    
} else
{
    Console.WriteLine($"{employees[id]}");
}

