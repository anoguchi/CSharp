// Only .NET 6 +
// Only about date

DateOnly birthday = DateOnly.Parse("11/26/1986");

Console.WriteLine(birthday.ToString("dd/MM/yy"));

DateTime today = DateTime.Now;

Console.WriteLine($"Today full format: {today}");
Console.WriteLine($"Today just date: {today.Date}");
Console.WriteLine($"Birthday full format: {birthday}");