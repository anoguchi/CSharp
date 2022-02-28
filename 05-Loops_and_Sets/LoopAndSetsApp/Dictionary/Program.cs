// Key type and value type
// Instead of have index is based in value they pass in, helpful for finding or id's.
// Really useful for storing a set of data that you need to convert over.
// We don't use this too often.

Dictionary<string, string> lookup = new Dictionary<string, string>();

lookup["animal"] = "Not human";
lookup["fish"] = "Not a human that swims";
lookup["human"] = "Us";

Console.WriteLine($"The definition of fish is {lookup["fish"]}");

Dictionary<int, string> employees = new Dictionary<int, string>();


employees[95] = "Alberto";
employees[28] = "Ana";

Console.WriteLine($"The employee with ID number 28 is {employees[95]}.");

Dictionary<string, int> dayOfWeek = new Dictionary<string, int>();

dayOfWeek["Wednesday"] = 4;
dayOfWeek["Thurday"] = 5;
dayOfWeek["Friday"] = 6;

Console.WriteLine($"Wednesday is day number {dayOfWeek["Wednesday"]}");

