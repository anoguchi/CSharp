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
        public static void Welcome()
        {
            Console.WriteLine("Welcome!");
        }
        public static string GetUserName()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            return name;
        }
        public static void Greetings(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
    }
}
