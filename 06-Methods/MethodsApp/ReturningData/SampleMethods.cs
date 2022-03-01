using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingAMethod
{
    // static which means we can call them directly from our Program.CS
    public static class SampleMethods
    {
        public static void SayHi(string firstName)
        {
            Console.WriteLine($"Hi {firstName}!");
            Console.WriteLine("Have a good day!");
        }
        public static void SayGoodbye()
        {
            Console.WriteLine("Goodbye my friend!");
        }

        public static string GetUsersName()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            return name;
        }
    }
}
