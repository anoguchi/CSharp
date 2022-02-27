// Add students to a class roster List until there are no more students. Then print out the count of the students to the console.

string data = "Alberto,Julia,Beto,Paula,Ana,Amanda";

List<string> classRoster = data.Split(',').ToList();
Console.WriteLine(classRoster.Count);