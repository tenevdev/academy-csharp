using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.BonusScores
{
    class BonusScores
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            switch ((input - 1) / 3)
            {
                case 0: Console.WriteLine(input * 10);
                    break;
                case 1: Console.WriteLine(input * 100);
                    break;
                case 2: Console.WriteLine(input * 1000);
                    break;
                default:
                    Console.WriteLine("Not a digit or zero error!");
                    break;
            }
        }
    }
}
