// Single quote identifies a char like ','
// Double quotes identifies a string

string[] firstNames = new string[5];

firstNames[0] = "Alberto";
firstNames[1] = "Beto";
firstNames[2] = "Diego";
firstNames[3] = "Charles";
firstNames[4] = "Pedro";

Console.WriteLine($"The firstNames are {firstNames[0]}, {firstNames[1]}, {firstNames[2]}, {firstNames[3]}, {firstNames[4]}");


string data = "Alberto,Diego,Pedro,Maria,Amanda";
string[] names = data.Split(',');

Console.WriteLine(names[0]);
Console.WriteLine(names.Length);

string[] secondNames = new string[3] {"Noguchi", "Silva", "Tavar"};
int[] ages = new int[] { 1, 3, 4, 10 };