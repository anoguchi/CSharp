using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBook
{
    public static class GuestLogic
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the Guest Book App");
            Console.WriteLine("*****************************");
            Console.WriteLine();
        }

        public static string GetPartyName()
        {
            Console.Write("What is your party/group name? ");
            string output = Console.ReadLine();

            return output;
        }

        public static int GetPartySize()
        {
            bool isValidNumber;
            int output;
            do
            {

                Console.Write("How many people are in your party? ");
                string partySizeText = Console.ReadLine();
                isValidNumber = int.TryParse(partySizeText, out output);

                if (!isValidNumber)
                {
                    Console.WriteLine(NotValidNumberMessage());
                }

            } while (isValidNumber == false);
            return output;
        }

        public static string NotValidNumberMessage()
        {
            return "Not a valid number!";
        }

        public static bool AsKToContinue()
        {
            Console.Write("Are there more guests coming? (yes/no)");
            string continueLooping = Console.ReadLine();

            bool output = (continueLooping.ToLower() == "yes");

            return output;
        }

        public static (List<string> guests, int total) GetAllGuests()
        {
            int totalGuests = 0;
            List<string> guests = new List<string>();

            do
            {
                guests.Add(GetPartyName());

                // Get party size
                totalGuests += GetPartySize();



            } while (AsKToContinue());

            return (guests, totalGuests);

        }

        public static void DisplayGuests(List<string> guests)
        {
            foreach (string guest in guests)
            {
                Console.WriteLine(guest);
            }

        }

        public static void DisplayGuestCount(int totalGuests)
        {
            Console.WriteLine("Thank you everyone who attented.");
            Console.WriteLine($"The total guests count for this evening was {totalGuests}");
        }
    }
}
