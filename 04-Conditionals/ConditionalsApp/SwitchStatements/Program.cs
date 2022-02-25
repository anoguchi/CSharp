// 

string firstName = "Alberto";
int age = 18;

switch (firstName.ToLower())
{
    case "alberto":
    case "beto":
        Console.WriteLine("Hello Master");
        break;
    case "julia" or "yukiko":
        Console.WriteLine("Hello Julia");
        break;
    default:
        Console.WriteLine("I don't know you");
        break;
}

switch (age)
{
    case >= 0 and < 18:
        Console.WriteLine("You are a child");
        break;
    case >= 18 and < 66:
        Console.WriteLine("You should have a job");
        break;
    case >= 66:
        Console.WriteLine("Hopefully you are retired or retiring soon");
        break;
    default:
        Console.WriteLine("Age was not in an expected range.");
        break;
}