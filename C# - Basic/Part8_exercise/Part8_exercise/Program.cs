﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part8_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            ////1 - Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the numbers are consecutive.For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".

            //string[] elements;
            ////var numbers = new List<int>();

            //Console.WriteLine("Enter a few numbers separated by a hyphen: ");
            ////var input = Console.ReadLine();

            //elements = input.Split('-');

            //foreach (var elem in elements)
            //    numbers.Add(Convert.ToInt32(elem));

            //numbers.Sort();

            //var consNumbers = 0;

            //for (var i = 0; i < numbers.Count - 1; i++)
            //{
            //    if ((numbers[i] + 1 == numbers[i + 1]))
            //        consNumbers++;
            //}

            //var message = (consNumbers == numbers.Count - 1) ? "Consecutive" : "Not Consecutive";
            //Console.WriteLine(message);


            ////*****************
            //// from mosh:

            //console.write("enter a few numbers (eg 1-2-3-4): ");
            //var input = console.readline();

            //var numbers = new list<int>();
            //foreach (var number in input.split('-'))
            //    numbers.add(convert.toint32(number));

            //numbers.sort();

            //var isconsecutive = true;
            //for (var i = 1; i < numbers.count; i++)
            //{
            //    if (numbers[i] != numbers[i - 1] + 1)
            //    {
            //        isconsecutive = false;
            //        break;
            //    }
            //}

            //var message = isconsecutive ? "consecutive" : "not consecutive";
            //console.writeline(message);

            ///////////////////////////////////////////////////////////////////////////////

            ////2 - Write a program and ask the user to enter a few numbers separated by a hyphen.If the user simply presses Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.

            //Console.WriteLine("Enter numbers separated by an hyphen: ");
            //var input = Console.ReadLine();
            //var numbers = new List<int>();

            //if (String.IsNullOrEmpty(input))
            //    return;
            //else
            //{
            //    foreach (var number in input.Split('-'))
            //    {
            //        numbers.Add(Convert.ToInt32(number));
            //    }
            //    numbers.Sort();
            //    for (var i = 0; i < numbers.Count - 1; i++)
            //        if (numbers[i] == numbers[i + 1])
            //        {
            //            Console.WriteLine("Duplicate!");
            //            break;
            //        }
            //}

            ////*****************
            ////// From Mosh:
            //Console.Write("Enter a few numbers (eg 1-2-3-4): ");
            //var input = Console.ReadLine();

            //if (String.IsNullOrWhiteSpace(input))
            //    return;

            //var numbers = new List<int>();
            //foreach (var number in input.Split('-'))
            //    numbers.Add(Convert.ToInt32(number));

            ////var uniques = new List<int>();
            ////var includesDuplicates = false;
            ////foreach (var number in numbers)
            ////{
            ////    if (!uniques.Contains(number))
            ////        uniques.Add(number);
            ////    else
            ////    {
            ////        includesDuplicates = true;
            ////        break;
            ////    }
            ////}

            //if (ContainsDuplicates(numbers))
            //    Console.WriteLine("Duplicate");




            ///////////////////////////////////////////////////////////////////////////////

            //3- write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). a valid time should be between 00:00 and 23:59. if the time is valid, display "ok"; otherwise, display "invalid time". if the user doesn't provide any values, consider it as invalid time.

            //console.writeline("enter a time value in 24h format: ");
            //var input = console.readline();
            //var validtime = false;

            //if (string.isnullorempty(input))
            //    validtime = false;

            //var time = new list<int>();
            //foreach (var number in input.split(':'))
            //    time.add(convert.toint32(number));

            //if (time[0] < 24 && time[0] >= 0 && time[1] < 60 && time[1] >= 0)
            //    validtime = true;

            //if (validtime)
            //    console.writeline("valid time format");
            //else
            //    console.writeline("invalid time format!");


            //////*****************
            //////// From Mosh:

            //Console.Write("Enter time: ");
            //var input = Console.ReadLine();

            //if (String.IsNullOrWhiteSpace(input))
            //{
            //    Console.WriteLine("Invalid Time");
            //    return;
            //}

            //var components = input.Split(':');
            //if (components.Length != 2)
            //{
            //    Console.WriteLine("Invalid Time");
            //    return;
            //}

            //try
            //{
            //    var hour = Convert.ToInt32(components[0]);
            //    var minute = Convert.ToInt32(components[1]);

            //    if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
            //        Console.WriteLine("Ok");
            //    else
            //        Console.WriteLine("Invalid Time");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Invalid Time");
            //}

            ///////////////////////////////////////////////////////////////////////////////

            ////4- Write a program and ask the user to enter a few words separated by a space. Use the words to create a variable name with PascalCase. For example, if the user types: "number of students", display "NumberOfStudents". Make sure that the program is not dependent on the input. So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".

            //Console.WriteLine("Write a few words");
            //var input = Console.ReadLine();

            //if (String.IsNullOrEmpty(input))
            //{
            //    Console.WriteLine("Error");
            //    return;
            //}

            //var words = new List<string>();
            //var PascalCase = new List<string>();

            //foreach (var word in input.Split(' '))
            //    words.Add(word.ToLower());


            ////foreach (var word in words)
            ////{
            ////    var firstLetter = word[0];
            ////    var restOfWord = ;
            ////    PascalCase.Add(temp);
            ////}

            //foreach (var word in words)
            //    Console.WriteLine(word);

            ////////*****************
            ////////// From Mosh:

            //Console.Write("Enter a few words: ");
            //var input = Console.ReadLine();

            //if (String.IsNullOrWhiteSpace(input))
            //{
            //    Console.WriteLine("Error");
            //    return;
            //}

            //var variableName = "";
            //foreach (var word in input.Split(' '))
            //{
            //    var wordWithPascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
            //    variableName += wordWithPascalCase;
            //}

            //Console.WriteLine(variableName);


            ///////////////////////////////////////////////////////////////////////////////

            ////5- Write a program and ask the user to enter an English word. Count the number of vowels (a, e, o, u, i) in the word. So, if the user enters "inadequate", the program should display 6 on the console.

            //// From Mosh:
            //Console.WriteLine("Enter a word: ");
            //var input = Console.ReadLine().ToLower();

            //var vowels = new List<char>(new char[] { 'a', 'e', 'i', 'o', 'u' });
            //var vowelCount = 0;

            //foreach (var character in input)
            //{
            //    if (vowels.Contains(character))
            //        vowelCount++;
            //}

            //Console.WriteLine(vowelCount);

        }

        // Procedural:
            // Exercise 2:
            public bool ContainsDuplicates(List<int> numbers)
            {
                var uniques = new List<int>();
                foreach (var number in numbers)
                {
                    if (!uniques.Contains(number))
                        uniques.Add(number);
                    else
                        return true;
                }
                return false;
            }

            // Exercise 3:

    }
}
