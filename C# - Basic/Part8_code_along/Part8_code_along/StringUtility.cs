using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part8_code_along
{
    public class StringUtility
    {
        public static string SummariseText(string text, int maxLength = 20)
        {
            if (text.Length < maxLength)
                return text;

            //sentence.Substring(0, maxLength); // Poor method. You might cut off a word.
            var words = text.Split(' ');
            var totalCharacters = 0;
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                summaryWords.Add(word);

                totalCharacters += word.Length + 1;
                if (totalCharacters > maxLength)
                    break;
            }
            return String.Join(" ", summaryWords) + " ...";
        }
    }
}
