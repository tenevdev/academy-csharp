using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.LastDigitAsWordMethod
{
    class LastDigitAsWordMethod
    {
        static string GetLastDigitAsWord(int number)
        {
            switch (number % 10)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default:
                    return "not a digit";
                    break;
            }
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("The last digit is {0}", GetLastDigitAsWord(number);
        }
    }
}
