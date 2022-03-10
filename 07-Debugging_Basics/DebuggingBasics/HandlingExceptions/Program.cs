// An exception is when code does something unexpected or that is outside of what the processor or compiler can handle.
// With try/catch: Okay, yes, that's a problem  and i know what to do with that problem.

int[] ages = new int[] {1, 3, 5};

for (int i = 0; i <= ages.Length; i++)
{

    try
    {
        Console.WriteLine(ages[i]);
    }
    catch (Exception ex)
    {

        Console.WriteLine("We had an error.");
        Console.WriteLine(ex.Message);
        Console.WriteLine(ex);
        throw;
    }
}

Console.ReadLine();