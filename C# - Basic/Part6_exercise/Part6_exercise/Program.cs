using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part6_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

            //If no one likes your post, it doesn't display anything.
            //If only one person likes your post, it displays: [Friend's Name] likes your post.
            //If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
            //If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
            //Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.


            //while (true)
            //{
            //    Console.WriteLine("Enter a name: ");
            //    var input = Console.ReadLine();

            //    if (!String.IsNullOrEmpty(input));
            //    {
            //        Console.WriteLine(input);
            //        break;
            //    }
            //}   


            //// from Mosh
            //var names = new List<string>();

            //while (true)
            //{
            //    Console.Write("Type a name (or hit ENTER to quit): ");

            //    var input = Console.ReadLine();
            //    if (String.IsNullOrWhiteSpace(input))
            //        break;
            //    names.Add(input);
            //}

            //if (names.Count == 1)
            //    Console.WriteLine("{0} likes your post.", names[0]);
            //else if (names.Count == 2)
            //    Console.WriteLine("{0} and {1} like your post.", names[0], names[1]);
            //else if (names.Count > 2)
            //    Console.WriteLine("{0}, {1} and {2} others like your post.", names[0], names[1], names.Count - 2);

            //////////////////////////////////////////////////////////////////////////////////////////////////

            //2 - Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string.Display the reversed name on the console.

            //Console.WriteLine("Enter your name: ");
            //var name = Console.ReadLine();

            //var array = new char[name.Length];
            //for (var i = name.Length; i > 0; i--)
            //    array[name.Length - i] = name[i - 1];

            //var reversed = new string(array);
            //Console.WriteLine("Reversed name: " + reversed);

            //////////////////////////////////////////////////////////////////////////////////////////////////

            //3 - Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the result on the console.

            //var numbers = new List<int>();
            //var count = 0;

            //do
            //{
            //    Console.WriteLine("Enter 5 numbers: ");
            //    var input = Convert.ToInt32(Console.ReadLine());

            //    if (numbers.IndexOf(input) == -1)
            //    {
            //        numbers.Add(input);
            //        count++;
            //    }
            //    else
            //        Console.WriteLine("Number previously entered! Try another one.");
            //    continue;

            //} while (count < 3);

            //numbers.Sort();
            //foreach (var elem in numbers)
            //    Console.WriteLine(elem);

            //// from Mosh:

            //var numbers = new List<int>();

            //while (numbers.Count < 5)
            //{
            //    Console.Write("Enter a number: ");
            //    var number = Convert.ToInt32(Console.ReadLine());
            //    if (numbers.Contains(number))
            //    {
            //        Console.WriteLine("You've previously entered " + number);
            //        continue;
            //    }

            //    numbers.Add(number);
            //}

            //numbers.Sort();

            //foreach (var number in numbers)
            //    Console.WriteLine(number);

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            //4 - Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may include duplicates. Display the unique numbers that the user has entered.

            //var numbers = new List<int>();

            //while (true)
            //{
            //    Console.WriteLine("Enter a number or type \"Quit\" to exit: ");
            //    var input = Console.ReadLine();

            //    if (input.ToLower() == "quit")
            //        break;

            //        numbers.Add(Convert.ToInt32(input));
            //}

            //var uniques = new List<int>();
            //foreach ( var number in numbers)
            //{
            //    if (!uniques.Contains(number))
            //        uniques.Add(number);
            //}

            //Console.WriteLine("Unique Numbers:");
            //foreach (var u in uniques)
            //    Console.WriteLine(u);

            ////////////////////////////////////////////////////////////////////////////////////////////////////


            //5 - Write a program and ask the user to supply a list of comma separated numbers(e.g 5, 1, 9, 2, 10). If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.

            string[] elements;

            while (true)
            {
                Console.WriteLine("Enter a list of 5 numbers separated by commas: ");
                var input = Console.ReadLine();

                elements = input.Split(',');

                if (!String.IsNullOrWhiteSpace(input) && elements.Length >= 5)
                    break;

                if (elements.Length < 5)
                    Console.WriteLine("Invalid List. Re-try.");
            }
            
            var numbers = new List<int>();
            foreach (var number in elements)
                numbers.Add(Convert.ToInt32(number));

            var smallests = new List<int>();
            while (smallests.Count < 3)
            {
                // Assume the first number is the smallest
                var min = numbers[0];
                foreach (var number in numbers)
                {
                    if (number < min)
                        min = number;
                }
                smallests.Add(min);

                numbers.Remove(min);
            }

            Console.WriteLine("The smallest 3 numbers are: ");
            foreach (var n in smallests)
                Console.WriteLine(n);
        }
    }
}
