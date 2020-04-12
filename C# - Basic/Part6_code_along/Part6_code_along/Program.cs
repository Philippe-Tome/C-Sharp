using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part6_code_along
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays: *********************************************************
            var numbers = new [] { 3, 7, 9, 2, 14, 6 };

            // Length
            Console.WriteLine("Lenght " + numbers.Length);

            // IndexOf()
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9 is: " + index);

            // Clear() -> if int clearing means 0, if bool clearing means false.
            Array.Clear(numbers, 0, 2);

            Console.WriteLine("Effect of Clear()");
            foreach (var n in numbers)
                Console.WriteLine(n);

            // Copy()
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);

            Console.WriteLine("Effect of Copy()");
            foreach (var n in another)
                Console.WriteLine(n);

            // Sort()
            Array.Sort(numbers);

            Console.WriteLine("Effect of Sort()");
            foreach (var n in numbers)
                Console.WriteLine(n);

            // Reverse()
            Array.Reverse(numbers);

            Console.WriteLine("Effect of Reverse()");
            foreach (var n in numbers)
                Console.WriteLine(n);

            ///////////////////////////////////////////////////////////////////////////////////

            // Lists: *********************************************************

            Console.WriteLine();

            var numbers1 = new List<int>() { 1, 2, 3, 4};
            numbers1.Add(1);
            numbers1.AddRange(new int[3] { 5, 6, 7 });
            
            foreach (var n in numbers1)
                Console.WriteLine(n);

            Console.WriteLine();
            // IndexOf()
            Console.WriteLine("Index of 1: " + numbers1.IndexOf(1));

            // LastIndexOf()
            Console.WriteLine("Last Index of 1: " + numbers1.LastIndexOf(1));

            // Count
            Console.WriteLine("Count: " + numbers1.Count);

            for (var i = 0; i < numbers1.Count; i++)
            {
                if (numbers1[i] == 1)
                    numbers1.Remove(numbers1[i]);
            }
            
            foreach (var n in numbers1)
                Console.WriteLine(n);

            // Clear()
            numbers1.Clear();
            Console.WriteLine("Count: " + numbers1.Count);

        }
    }
}
