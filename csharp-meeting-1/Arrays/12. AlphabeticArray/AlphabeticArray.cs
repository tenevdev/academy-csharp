
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.AlphabeticArray
{
    class AlphabeticArray
    {
        static void Main(string[] args)
        {
            int alphabetLength = 26, aPosition = 65;
            char[] alphabet = new char[alphabetLength];
            for (int i = aPosition; i < aPosition + alphabetLength; i++)
            {
                alphabet[i - aPosition] = (char)i;
            }

            Console.WriteLine("Enter a word: ");
            string input = Console.ReadLine().ToUpper();

            foreach (var letter in input)
            {
                Console.Write("{0} ", Array.IndexOf(alphabet,letter));
            }
        }
    }
}
