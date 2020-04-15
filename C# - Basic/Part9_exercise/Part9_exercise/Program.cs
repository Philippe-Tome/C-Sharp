using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Part9_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - Write a program that reads a text file and displays the number of words.
            //var path = @"C:\Users\ptome\MEGA\Shared Emma - Philippe\Philippe\Study\Developer\C-Sharp\C# - Basic\test.txt";

            //var content = File.ReadAllText(path).Split(' ');
            
            //Console.WriteLine(content.Length);

            //2 - Write a program that reads a text file and displays the longest word in the file.
            var path = @"C:\Users\ptome\MEGA\Shared Emma - Philippe\Philippe\Study\Developer\C-Sharp\C# - Basic\test.txt";

            var content = File.ReadAllText(path).Split(' ');

            // Assume first word is the longest:
            var longestWord = content[0];
            foreach (var word in content)
            {
                if (word.Length > longestWord.Length)
                    longestWord = word;
            }

            Console.WriteLine(longestWord);
        }
    }
}
