// Variables hold information
// type variableName
// \n = scape character
// Hungarian notation: string strFirstName = "Beto";

string firstName = string.Empty;
string lastName = string.Empty;
string differentFirstName = "";
string filePath = string.Empty;

firstName = "Beto";
lastName = "Hideyo";
filePath = "C:\\Temp\\Demo";
string filePath02 = @"C:\\Temp\\Demo02";

firstName = "Alberto";

string testString = $@"The file for {firstName} is at C:\SampleFiles";

Console.WriteLine(firstName + " " + lastName);

// String interpolation
Console.WriteLine($"Hello! {firstName} {lastName}");
Console.WriteLine(filePath);
Console.WriteLine(filePath02);
Console.WriteLine(testString);