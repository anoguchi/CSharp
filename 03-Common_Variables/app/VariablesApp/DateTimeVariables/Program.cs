//

using System.Globalization;

DateTime today = DateTime.UtcNow;
DateTime today02 = DateTime.UtcNow;

DateTime birthday = DateTime.Parse("6/15/1998");
DateTime birthday2 = DateTime.ParseExact("6/11/1998","d/M/yyyy", CultureInfo.InvariantCulture);

Console.WriteLine(today.ToString("dd MMMM, yyyy hh:mm tt zzz"));

Console.WriteLine(today02);

Console.WriteLine(birthday);

Console.WriteLine(birthday2);


