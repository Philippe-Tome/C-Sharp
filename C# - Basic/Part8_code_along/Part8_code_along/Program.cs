using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part8_code_along
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Demo String:
            // Trim, Upper:
            var fullName = "Mosh Hamedani ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            // Split:
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("FirstName: " + firstName);
            Console.WriteLine("LastName: " + lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);

            // Replace:
            Console.WriteLine(fullName.Replace("Mosh", "Moshfegh"));

            // String validation:
            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");

            // Convert number to string and vice-versa:
            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("c")); // currency format with 2 decimal points
            Console.WriteLine(price.ToString("c0")); // currency format with no decimal points. rounds the number.

            // ****************************************************************************

            // 4. Live Coding Summarising:

            // Class StringUtility created and reused in this program.

            var sentence = "This is going to be a really really really really really long text";

            var summary = StringUtility.SummariseText(sentence, 24);
            Console.WriteLine(summary);

            // ****************************************************************************

            // 6. StringBuilder: 

            var builder = new StringBuilder("Hello world");

            builder.Append('-', 10)
                   .AppendLine()
                   .Append("Header")
                   .AppendLine()
                   .Append('-', 10)
                   .Replace('-', '+')
                   .Remove(0, 10)
                   .Insert(0, new string('-', 10));
            
            Console.WriteLine(builder);

            Console.WriteLine(builder[0]);

            // ****************************************************************************

            // 9. Procedural Programming:
                // Example 1:
                Console.WriteLine("What's your name? ");
                var name = Console.ReadLine();

                var reversed = ReverseName(name);

                Console.WriteLine("Reversed name: " + reversed);


                // Example 2:
                var numbers = new List<int>();

                while (true)
                {
                    Console.WriteLine("Enter a number (or 'Quit' to exit): ");
                    var input = Console.ReadLine();

                    if (input.ToLower() == "quit")
                        break;

                    numbers.Add(Convert.ToInt32(input));
                }

                Console.WriteLine("Unique numbers: ");
                foreach (var number in GetUniqueNumbers(numbers))
                    Console.WriteLine(number);
                
        }

        // Example 1 method:
        public static string ReverseName(string name)
        {
            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];

            return new string(array);
        }

        // Example 2 method:
        public static List<int> GetUniqueNumbers(List<int> numbers)
        {
            var uniques = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
            }

            return uniques;
        }
    }
}
 