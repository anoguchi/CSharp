// Is like array but with new additionals
// If you have a set of datas use Lists
// List<T>: generic

List<string> firstNames = new List<string>();
firstNames.Add("Beto");
firstNames.Add("Julia");
firstNames.Add("Alberto");
firstNames.Add("Paula");

Console.WriteLine(firstNames[0]);
Console.WriteLine(firstNames[firstNames.Count - 1]);

List<int> ages = new List<int>();
ages.Add(1);
ages.Add(2);
ages.Add(3);

string data = "Alberto,Julia,Beto";

// Array to List
List<string> names = data.Split(',').ToList();
names.Add("Paula");

