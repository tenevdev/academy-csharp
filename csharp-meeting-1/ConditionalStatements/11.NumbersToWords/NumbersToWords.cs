using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.NumbersToWords
{
    class NumbersToWords
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number >= 0 && number < 20)
            {
                Print0To19(number % 100);
            }
            else if (number > 20 && number < 100)
            {
                switch (number / 10)
                {
                    case 2: Console.Write("twenty "); break;
                    case 3: Console.Write("thirty "); break;
                    case 4: Console.Write("forty "); break;
                    case 5: Console.Write("fifty "); break;
                    case 6: Console.Write("sixty "); break;
                    case 7: Console.Write("seventy "); break;
                    case 8: Console.Write("eighty "); break;
                    case 9: Console.Write("ninety "); break;
                    default: Console.Write(" "); break;

                }
                switch (number % 10)
                {
                    case 0: Console.WriteLine(" "); break;
                    case 1: Console.WriteLine("one"); break;
                    case 2: Console.WriteLine("two"); break;
                    case 3: Console.WriteLine("three"); break;
                    case 4: Console.WriteLine("four"); break;
                    case 5: Console.WriteLine("five"); break;
                    case 6: Console.WriteLine("six"); break;
                    case 7: Console.WriteLine("seven"); break;
                    case 8: Console.WriteLine("eight"); break;
                    default: Console.WriteLine("nine"); break;

                }
            }
            else if (number > 99 && number < 1000)
            {
                if ((number % 100) > 0 && (number % 100) < 20)
                {
                    PrintHundreds(number / 100);
                    Console.Write("and ");
                    Print0To19(number % 100);
                }
                else
                {
                    PrintHundreds(number / 100);
                    switch ((number / 10) % 10)
                    {
                        case 2: Console.Write("twenty "); break;
                        case 3: Console.Write("thirty "); break;
                        case 4: Console.Write("fourty "); break;
                        case 5: Console.Write("fifty "); break;
                        case 6: Console.Write("sixty "); break;
                        case 7: Console.Write("seventy "); break;
                        case 8: Console.Write("eighty "); break;
                        case 9: Console.Write("ninety "); break;
                        default: Console.Write(" "); break;

                    }
                    switch (number % 10)
                    {
                        case 0: Console.WriteLine(" "); break;
                        case 1: Console.WriteLine("one"); break;
                        case 2: Console.WriteLine("two"); break;
                        case 3: Console.WriteLine("three"); break;
                        case 4: Console.WriteLine("four"); break;
                        case 5: Console.WriteLine("five"); break;
                        case 6: Console.WriteLine("six"); break;
                        case 7: Console.WriteLine("seven"); break;
                        case 8: Console.WriteLine("eight"); break;
                        case 9: Console.WriteLine("nine"); break;
                        default: Console.WriteLine(" "); break;

                    }
                }
            }
        }

        private static void Print0To19(int num)
        {
            switch (num)
            {
                case 0: Console.WriteLine("zero"); break;
                case 1: Console.WriteLine("one"); break;
                case 2: Console.WriteLine("two"); break;
                case 3: Console.WriteLine("three"); break;
                case 4: Console.WriteLine("four"); break;
                case 5: Console.WriteLine("five"); break;
                case 6: Console.WriteLine("six"); break;
                case 7: Console.WriteLine("seven"); break;
                case 8: Console.WriteLine("eight"); break;
                case 9: Console.WriteLine("nine"); break;
                case 10: Console.WriteLine("ten"); break;
                case 11: Console.WriteLine("eleven"); break;
                case 12: Console.WriteLine("twelve"); break;
                case 13: Console.WriteLine("thirteen"); break;
                case 14: Console.WriteLine("fourteen"); break;
                case 15: Console.WriteLine("fifteen"); break;
                case 16: Console.WriteLine("sexteen"); break;
                case 17: Console.WriteLine("seventeen"); break;
                case 18: Console.WriteLine("eighteen"); break;
                default: Console.WriteLine("nineteen");
                    break;
            }
        }

        private static void PrintHundreds(int num)
        {
            switch (num)
            {
                case 1: Console.Write("One hundred "); break;
                case 2: Console.Write("two hundred "); break;
                case 3: Console.Write("three hundred "); break;
                case 4: Console.Write("four hundred "); break;
                case 5: Console.Write("five hundred "); break;
                case 6: Console.Write("six hundred "); break;
                case 7: Console.Write("seven hundreds "); break;
                case 8: Console.Write("eight hundred "); break;
                case 9: Console.Write("nine hundred "); break;
                default: Console.Write(" "); break;
            }
        }
    }
}
