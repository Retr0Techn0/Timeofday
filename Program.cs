using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DayPeriodIdentifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an hour (0-23):");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int hour) && hour >= 0 && hour <= 23)
            {
                string periodOfDay;

                switch (hour)
                {
                    case int h when (h >= 5 && h < 12):
                        periodOfDay = "Morning";
                        break;
                    case int h when (h >= 12 && h < 17):
                        periodOfDay = "Afternoon";
                        break;
                    case int h when (h >= 17 && h < 21):
                        periodOfDay = "Evening";
                        break;
                    default:
                        periodOfDay = "Night";
                        break;
                }

                Console.WriteLine($"The period of the day for hour {hour} is: {periodOfDay}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid hour between 0 and 23.");
            }

            Console.ReadLine();
        }
    }
}