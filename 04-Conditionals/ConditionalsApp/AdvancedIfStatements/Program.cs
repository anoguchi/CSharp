// 

Console.Write("What is your first name?: ");
string firstName = Console.ReadLine();

Console.Write("What is your last name?: ");
string lastName = Console.ReadLine();

// Can be just one of three statements
if (firstName.ToLower() == "alberto" && lastName.ToLower() == "noguchi")
{
    Console.WriteLine($"Hello {firstName} {lastName}");
}

else if (firstName.ToLower() == "alberto")
{
    Console.WriteLine($"Hello {firstName}");
}
else if (lastName.ToLower() == "noguchi")
{
    Console.WriteLine($"You have a great last name!");
}
else
{
    Console.WriteLine("Sorry you don't have a cooler name!");
}
// --------------------------------

// Can be more than three statements
if (firstName.ToLower() == "julia")
{
    Console.WriteLine("You have a cool name");
}
if (lastName.ToLower() == "yukiko")
{
    Console.WriteLine("You have a cool lastname");
}
else
{
    Console.WriteLine("You don't have a cooler name");
}
// --------------------------------

int age = 73;
// Will evaluate first parentheses and or second parentheses
// You can use parentheses to change the evaluation set
if ((age >= 40 && age < 50) || 
    (age >= 70 && age < 80))
{
    Console.WriteLine("You are in your 40's or 70's");
}
