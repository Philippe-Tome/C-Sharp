using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part5_Exercises
{
    class Program
    {

        //public enum ImageOrientation
        //{
        //    Landscape,
        //    Portrait
        //}

        static void Main(string[] args)
        {
            ////1 - Write a program and ask the user to enter a number. The number should be between 1 to 10.If the user enters a valid number, display "Valid" on the console.Otherwise, display "Invalid". (This logic is used a lot in applications where values entered into input boxes need to be validated.)

            //Console.Write("Enter a number between 1 and 10: ");
            //var input = Console.ReadLine();
            //var numberInput = Convert.ToInt32(input);

            ////Console.WriteLine(input);

            //if (numberInput >= 1 && numberInput <= 10)
            //{
            //Console.WriteLine("Valid");
            //} else
            //{
            //Console.WriteLine("Invalid");
            //}

            ///////////////////////////////////////////////////////////////////////////////////

            //2 - Write a program which takes two numbers from the console and displays the maximum of the two.

            //Console.WriteLine("Enter your first number: ");
            //var inputFirst = Console.ReadLine();
            //var firstNumber = Convert.ToInt32(inputFirst);

            //if (!String.IsNullOrWhiteSpace(inputFirst))
            //{
            //    Console.WriteLine("Enter your second number: ");
            //    var inputSecond = Console.ReadLine();
            //    var secondNumber = Convert.ToInt32(inputSecond);

            //    if (!String.IsNullOrWhiteSpace(inputSecond) && firstNumber > secondNumber)
            //    {
            //        Console.WriteLine("The first number is the greatest with: " + firstNumber);
            //    } else
            //    {
            //        Console.WriteLine("The second number is the greatest with: " + secondNumber);
            //    }
            //}

            /* From Amosh
            Console.Write("Enter a number: ");
            var number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number: ");
            var number2 = Convert.ToInt32(Console.ReadLine());

            var max = (number1 > number2) ? number1 : number2;
            Console.WriteLine("Max is " + max);
            */

            /////////////////////////////////////////////////////////////////////////////////

            ////3 - Write a program and ask the user to enter the width and height of an image.Then tell if the image is landscape or portrait.

            //Console.WriteLine("Enter the width of the image: ");
            //var width = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the height of the image: ");
            //var height = Convert.ToInt32(Console.ReadLine());

            ////if (width > height)
            ////{
            ////    Console.WriteLine("It is landscape.");
            ////} else
            ////{
            ////    Console.WriteLine("It is portrait.");
            ////}

            //var orientation = width > height ? ImageOrientation.Landscape : ImageOrientation.Portrait;
            //Console.WriteLine("Image orientation is " + orientation);

            /////////////////////////////////////////////////////////////////////////////////

            //4 - Your job is to write a program for a speed camera.For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic. Write a program that asks the user to enter the speed limit.Once set, the program asks for the speed of a car.If the user enters a value less than the speed limit, program should display Ok on the console. If the value is above the speed limit, the program should calculate the number of demerit points.For every 5km / hr above the speed limit, 1 demerit points should be incurred and displayed on the console. If the number of demerit points is above 12, the program should display License Suspended.

            //Console.WriteLine("Enter the speed limit: ");
            //var speedLimit = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the speed of the car: ");
            //var carSpeed = Convert.ToInt32(Console.ReadLine());

            //if (carSpeed < speedLimit)
            //    Console.WriteLine("OK");
            //else
            //{
            //    const int kmPerDemeritPoint = 5;
            //    var demeritPoints = (carSpeed - speedLimit) / kmPerDemeritPoint;
            //    if (demeritPoints > 12)
            //        Console.WriteLine("Licence suspended!");
            //    else
            //    {
            //        Console.WriteLine("You have lost " + demeritPoints + " demerit points.");
            //    }
            //}

            /////////////////////////////////////////////////////////////////////////////////////////

            ////1 - Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.Display the count on the console.

            //var count = 0;
            //for (var i = 1; i <= 100; i++)
            //{
            //    if (i % 3 == 0)
            //        count++;
            //}
            //Console.WriteLine("There are {0} numbers divisible by 3 between 1 and 100.", count);

            /////////////////////////////////////////////////////////////////////////////////////////

            //2 - Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.

            //var number = 0;
            //while (true)
            //{
            //    Console.WriteLine("Enter a number: ");
            //    var input = Console.ReadLine();
            //    if (input.ToLower() != "ok")
            //    {
            //        number += Convert.ToInt32(input);
            //    }
            //    else
            //    { 
            //        Console.WriteLine(number);
            //        break;
            //    } 
            //}

            //// from Mosh:
            //var sum = 0;
            //while (true)
            //{
            //    Console.Write("Enter a number (or 'ok' to exit): ");
            //    var input = Console.ReadLine();

            //    if (input.ToLower() == "ok")
            //        break;

            //    sum += Convert.ToInt32(input);
            //}
            //Console.WriteLine("Sum of all numbers is: " + sum);

            ///////////////////////////////////////////////////////////////////////////////////////////

            ////3 - Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

            //Console.WriteLine("Enter a number: ");
            //var input = Convert.ToInt32(Console.ReadLine());

            //var factorial = 1;
            //for (var i = input; i > 0; i--)
            //    factorial *= i;

            //Console.WriteLine("{0}! = {1}", input, factorial);

            ///////////////////////////////////////////////////////////////////////////////////////////

            //4 - Write a program that picks a random number between 1 and 10.Give the user 4 chances to guess the number.If the user guesses the number, display “You won"; otherwise, display “You lost". (To make sure the program is behaving correctly, you can display the secret number on the console first.)

            //Random random = new Random();
            //int rnd = random.Next(1, 10);
            //Console.WriteLine(rnd);

            //var count = 0;
            //while (count < 4)
            //{
            //    Console.WriteLine("Enter your guess number: ");
            //    var input = Convert.ToInt32(Console.ReadLine());
            //    count++;
            //    if (input != rnd)
            //        Console.WriteLine("You lost");
            //    continue;
            //    else 
            //        Console.WriteLine("You won!");
            //    break;
            //}

            //// from Mosh:

            //var number = new Random().Next(1, 10);

            //Console.WriteLine("Secret is " + number);

            //for (var i = 0; i < 4; i++)
            //{
            //    Console.Write("Guess the secret number: ");
            //    var guess = Convert.ToInt32(Console.ReadLine());

            //    if (guess == number)
            //    {
            //        Console.WriteLine("You won!");
            //        return;
            //    }
            //}

            //Console.WriteLine("You lost!");

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////

            //5 - Write a program and ask the user to enter a series of numbers separated by comma.Find the maximum of the numbers and display it on the console. For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.

            //Console.WriteLine("Enter a series of number separated by a comma.");
            //var seriesInput = new int[] { Convert.ToInt32(Console.ReadLine()) };
            //Console.WriteLine(seriesInput);


            // from Mosh:

            Console.Write("Enter comma separated numbers: ");
            var input = Console.ReadLine();

            var numbers = input.Split(',');

            // Assume the first number is the max 
            var max = Convert.ToInt32(numbers[0]);

            foreach (var str in numbers)
            {
                var number = Convert.ToInt32(str);
                if (number > max)
                    max = number;
            }
            Console.WriteLine("Max is " + max);
        }
    }
}
