using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part7_code_along
{
    class Program
    {
        static void Main(string[] args)
        {
            // DateTime:
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("today day: " + today.Day + " today day of the year: " + today.DayOfYear);
            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Minutes: " + now.Minute);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString());
            Console.WriteLine(now.ToString("dd-MM-yyyy HH:mm"));

            // C# datetime format specifier

            //**********************************

            //TimeSpan:
                // Creating timeSpan object:
                var timeSpan = new TimeSpan(1, 2, 3);
                var timeSpan1 = new TimeSpan(1, 0, 0);
                var timeSpan2 = TimeSpan.FromHours(1);

                var start = DateTime.Now;
                var end = DateTime.Now.AddMinutes(2);
                var duration = end - start;

                Console.WriteLine("Duration: " + duration);

                // Properties:
                Console.WriteLine("Minutes: " + timeSpan.Minutes);
                Console.WriteLine("Minutes: " + timeSpan.TotalMinutes);

                // Add:
                Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));

                // Subtract:
                Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

                // ToString:
                Console.WriteLine("ToString: " + timeSpan.ToString());

                // Parse:
                Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));
        }
    }
}
